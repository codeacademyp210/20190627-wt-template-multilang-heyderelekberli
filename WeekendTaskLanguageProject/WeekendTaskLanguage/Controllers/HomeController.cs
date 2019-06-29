using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Ability = db.Abilities.ToList();
            models.AboutSpec = db.AboutSpecs.ToList();
            models.Blog = db.Blogs.ToList();
            models.Comment = db.Comments.ToList();
            models.HomeImage = db.HomeImages.ToList();
            models.Position = db.Positions.ToList();
            models.Post = db.Posts.ToList();
            models.SecondBlog = db.SecondBlogs.ToList();
            models.Service = db.Services.ToList();
            models.Speciality = db.Specialities.ToList();
            models.Team = db.Teams.ToList();
            models.Testimonial = db.Testimonials.ToList();
            models.Setting = Setting;
            return View(models);
      
        }
    }
}