using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeekendTaskLanguage.DAL;
using WeekendTaskLanguage.Models;

namespace WeekendTaskLanguage.Areas.Admin.Controllers
{
    public class HomeImageController : Controller
    {
        private TempContext db = new TempContext();

        // GET: Admin/HomeImage
        public ActionResult Index()
        {
            return View(db.HomeImages.ToList());
        }

        // GET: Admin/HomeImage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImage homeImage = db.HomeImages.Find(id);
            if (homeImage == null)
            {
                return HttpNotFound();
            }
            return View(homeImage);
        }

        // GET: Admin/HomeImage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeImage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,Title,Text")] HomeImage homeImage)
        {
            if (ModelState.IsValid)
            {
                db.HomeImages.Add(homeImage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeImage);
        }

        // GET: Admin/HomeImage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImage homeImage = db.HomeImages.Find(id);
            if (homeImage == null)
            {
                return HttpNotFound();
            }
            return View(homeImage);
        }

        // POST: Admin/HomeImage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image,Title,Text")] HomeImage homeImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeImage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeImage);
        }

        // GET: Admin/HomeImage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeImage homeImage = db.HomeImages.Find(id);
            if (homeImage == null)
            {
                return HttpNotFound();
            }
            return View(homeImage);
        }

        // POST: Admin/HomeImage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeImage homeImage = db.HomeImages.Find(id);
            db.HomeImages.Remove(homeImage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
