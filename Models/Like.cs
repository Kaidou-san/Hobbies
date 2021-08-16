using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Like
    {
        [Key]
        public int LikeId {get; set;}
        public int UserId {get; set;}
        public int HobbyId {get; set;}
        //navigation properties
        public User UserWhoLiked {get; set;}
        public Hobby HobbiesLiked {get; set;}
    }
}