using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.DAL
{
    public class TempContext : DbContext
    {
        public TempContext() : base("TempleteConnection")
        {
        }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AboutSpec> AboutSpecs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<HomeImage> HomeImages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<SecondBlog> SecondBlogs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Setting> Settings { get; set; }
    
    }
}