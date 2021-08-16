using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        // dont forget to add ur DBSet here!!
        public DbSet<User> Users {get; set;}
        public DbSet<Hobby> Hobbies {get; set;}
        public DbSet<Like> Likes {get; set;}
        public DbSet<Category> Categories {get; set;}
    }
}