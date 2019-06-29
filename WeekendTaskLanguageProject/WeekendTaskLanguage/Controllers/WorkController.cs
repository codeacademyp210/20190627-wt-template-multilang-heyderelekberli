using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class WorkController : BaseController
    {
        // GET: Work
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Portfolio = db.Portfolios.ToList();
            models.Testimonial = db.Testimonials.ToList();

            return View(models);
        }
    }
}