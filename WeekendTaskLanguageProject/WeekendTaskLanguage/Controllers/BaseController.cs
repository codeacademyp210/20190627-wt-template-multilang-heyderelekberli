using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.DAL;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class BaseController : Controller
    {
        protected TempContext db;
        protected Blog Blog;
        protected Ability Ability;
        protected AboutSpec AboutSpec;
        protected Comment Comment;
        protected Portfolio Portfolio;
        protected HomeImage HomeImage;
        protected Position Position;
        protected Post Post;
        protected SecondBlog SecondBlog;
        protected Service Service;
        protected Speciality Speciality;
        protected Team Team;
        protected Testimonial Testimonial;
        protected Setting Setting;



        protected BaseController()
        {
            db = new TempContext();
            Blog = db.Blogs.FirstOrDefault();
            Ability = db.Abilities.FirstOrDefault();
            AboutSpec = db.AboutSpecs.FirstOrDefault();
            Comment = db.Comments.FirstOrDefault();
            Portfolio = db.Portfolios.FirstOrDefault();
            HomeImage = db.HomeImages.FirstOrDefault();
            Position = db.Positions.FirstOrDefault();
            Post = db.Posts.FirstOrDefault();
            SecondBlog = db.SecondBlogs.FirstOrDefault();
            Service = db.Services.FirstOrDefault();
            Speciality = db.Specialities.FirstOrDefault();
            Team = db.Teams.FirstOrDefault();
            Testimonial = db.Testimonials.FirstOrDefault();
            Setting = db.Settings.FirstOrDefault();
            ViewBag.Setting = db.Settings.FirstOrDefault();

        }

    }
}