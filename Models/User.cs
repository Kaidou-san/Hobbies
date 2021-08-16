using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "Name must be 2 characters!")]
        public string FirstName {get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "Name must be 2 characters!")]
        public string LastName {get; set;}
        [Required]
        [Range(3,15)]
        public string Username {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "PW must b 8 characters!")]
        public string Password {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Like> LikeHobbies {get; set;}
        public List<Hobby> AllHobbies {get; set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPW {get; set;}

    }
}