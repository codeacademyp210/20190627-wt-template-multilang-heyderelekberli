using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Controllers
{
    public class ServiceController : BaseController
    {
        // GET: Service
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Position = db.Positions.ToList();
            models.Service = db.Services.ToList();
            models.Testimonial = db.Testimonials.ToList();
            return View(models);
        }
    }
}