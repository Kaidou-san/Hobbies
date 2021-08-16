using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                //Email must be unique!
                if (_context.Users.Any(e => e.Username == newUser.Username))
                {
                    ModelState.AddModelError("Username", "Username Taken already");
                    return View("Index");
                }
                else
                {
                    // We have verification that all is well and we can add to the database
                    // WE NEED TO HASH OUR PW
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("LoggedIn", newUser.UserId);
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser logUser)
        {
            if (ModelState.IsValid)
            {
                //VERIFY EMAIL GIVEN IS THE DATABASE
                User userInDb = _context.Users.FirstOrDefault(u => u.Username == logUser.LUsername);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LUsername", "Invalid login attempt");
                    return View("Index");
                }
                //CHECK THE PW VS THE PW IN THE USER HAS IN THE DATABASE
                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LPassword);
                if (result == 0)
                {
                    //IF ITS 0 THAT MEANS WE FAILED TO VERIFY
                    ModelState.AddModelError("LUsername", "Invalid login attempt");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("loggedIn", userInDb.UserId);
                    //AFTER SUCCESSFULLY DO BOTH, WE HEAD TO THE SUCCESS PAGE
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");
            }
        }
        
        [HttpGet("success")]
        public IActionResult Success()
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if (loggedIn != null)
            {
                ViewBag.User = _context.Users.Include(s => s.LikeHobbies)
                .ThenInclude(d => d.HobbiesLiked).FirstOrDefault(a => a.UserId == (int)loggedIn);
                ViewBag.AllHobbies = _context.Hobbies.Include(w => w.UserWhoLikes).ToList();
                return View();
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("addHobby")]
        public IActionResult addHobby()
        {
            return View();
        }

        [HttpPost("HobbyToDb")]
        public IActionResult WeddingToDb(Hobby newHobby)
        {
            if(ModelState.IsValid)
            {
                newHobby.UserId = (int)HttpContext.Session.GetInt32("loggedIn");
                _context.Add(newHobby);
                _context.SaveChanges();
                return RedirectToAction("success");
            }else {
                return View("addHobby");
            }
        }

        [HttpGet("like/{UserId}/{HobbyId}")]
        public IActionResult Like(int UserId, int HobbyId)
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != null)
            {
                if((int)loggedIn != UserId)
                {
                    return RedirectToAction("logout");
                } else {
                    Like newLike = new Like();
                    newLike.UserId = UserId;
                    newLike.HobbyId = HobbyId;
                    _context.Likes.Add(newLike);
                    _context.SaveChanges();
                    return RedirectToAction("success");
                }
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("unlike/{UserId}/{HobbyId}")]
        public IActionResult unlike(int UserId, int HobbyId)
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != null)
            {
                if((int)loggedIn != UserId)
                {
                    return RedirectToAction("logout");
                } else {
                    Like newLike = new Like();
                    Like LikesToRemove = _context.Likes
                    .FirstOrDefault(a => a.HobbyId == HobbyId && a.UserId == UserId);
                    _context.Likes.Remove(LikesToRemove);
                    _context.SaveChanges();
                    return RedirectToAction("success");
                }
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("hobby/{HobbyId}")]
        public IActionResult OneHobby(int HobbyId)
        {
            ViewBag.OneHobby = _context.Hobbies.Include(a => a.UserWhoLikes).ThenInclude(s => s.UserWhoLiked)
            .FirstOrDefault(m => m.HobbyId == HobbyId);
            ViewBag.AllCats = _context.Categories.ToList();
            return View();
        }

        [HttpPost("addCatToDb")]
        public IActionResult addCatToDb(Category newCat)
        {
            _context.Add(newCat);
            _context.SaveChanges();
            return RedirectToAction("success");
        }

        [HttpPost("addCatToHobby")]
        public IActionResult addCatToHobby(int HobbyId, Category newCat)
        {
            _context.Add(newCat);
            _context.SaveChanges();
            return Redirect("hobby/{HobbyId}");
        }

        [HttpGet("editHobby/{HobbyId}")]
        public IActionResult editHobby(int HobbyId)
        {
            Hobby HobbyToUpdate = _context.Hobbies.FirstOrDefault(h => h.HobbyId == HobbyId);
            return View(HobbyToUpdate);
        }

        [HttpPost("UpdateHobbyInDb/{HobbyId}")]
        public IActionResult UpdateHobbyInDb(int HobbyId, Hobby HobbyToUpdate)
        {
            Hobby OldHobby = _context.Hobbies.FirstOrDefault(a => a.HobbyId == HobbyId);
            if(ModelState.IsValid)
            {
                OldHobby.HobbyName = HobbyToUpdate.HobbyName;
                OldHobby.Description = HobbyToUpdate.Description;
                OldHobby.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("success");
            } else {
                return View("editHobby", OldHobby);
            }
        }

    }
}
