using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId {get; set;}
        [Required]
        public string HobbyName {get; set;}
        [Required]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public int UserId {get; set;}
        //navigation property
        public User User {get; set;}
        public List<Like> UserWhoLikes {get; set;}
        public Category CategoryOfHobby {get; set;}
        public List<Hobby> CatsOfHobby {get; set;}
        
    }
}