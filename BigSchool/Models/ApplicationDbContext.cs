using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public DbSet<Following> Followings { get; set; }
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasRequired(a => a.Course)
                .WithMany()
                .WillCascadeOnDelete(false);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followers)
                .WithRequired(f => f.Followee)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followees)
                .WithRequired(f => f.Follower)
                .WillCascadeOnDelete(false);
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
=======
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
            base.OnModelCreating(modelBuilder);
        }
    }
}