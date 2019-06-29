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
    public class AboutSpecController : Controller
    {
        private TempContext db = new TempContext();

        // GET: Admin/AboutSpec
        public ActionResult Index()
        {
            return View(db.AboutSpecs.ToList());
        }

        // GET: Admin/AboutSpec/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSpec aboutSpec = db.AboutSpecs.Find(id);
            if (aboutSpec == null)
            {
                return HttpNotFound();
            }
            return View(aboutSpec);
        }

        // GET: Admin/AboutSpec/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutSpec/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Text,Icon")] AboutSpec aboutSpec)
        {
            if (ModelState.IsValid)
            {
                db.AboutSpecs.Add(aboutSpec);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutSpec);
        }

        // GET: Admin/AboutSpec/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSpec aboutSpec = db.AboutSpecs.Find(id);
            if (aboutSpec == null)
            {
                return HttpNotFound();
            }
            return View(aboutSpec);
        }

        // POST: Admin/AboutSpec/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Text,Icon")] AboutSpec aboutSpec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutSpec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutSpec);
        }

        // GET: Admin/AboutSpec/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutSpec aboutSpec = db.AboutSpecs.Find(id);
            if (aboutSpec == null)
            {
                return HttpNotFound();
            }
            return View(aboutSpec);
        }

        // POST: Admin/AboutSpec/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutSpec aboutSpec = db.AboutSpecs.Find(id);
            db.AboutSpecs.Remove(aboutSpec);
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
