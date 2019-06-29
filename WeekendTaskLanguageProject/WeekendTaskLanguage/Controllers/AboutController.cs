using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Team = db.Teams.ToList();
            models.AboutSpec = db.AboutSpecs.ToList();
            models.Testimonial = db.Testimonials.ToList();
            models.Setting = Setting;
            return View(models);
        }
    }
}