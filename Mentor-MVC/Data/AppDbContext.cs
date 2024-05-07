using Mentor_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mentor_MVC.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feature> Features { get; set; }    
        public DbSet<Price> Prices { get; set; }
        public DbSet<CardFeatures> CardFeatures { get; set; } 
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
