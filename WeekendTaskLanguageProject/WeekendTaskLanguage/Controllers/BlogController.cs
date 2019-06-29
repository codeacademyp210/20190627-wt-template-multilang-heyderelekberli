using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.SecondBlog = db.SecondBlogs.ToList();
            models.Comment = db.Comments.ToList();
            models.Post = db.Posts.ToList();
            return View(models);
        }
    }
}