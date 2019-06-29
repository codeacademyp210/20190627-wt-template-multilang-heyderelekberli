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
    public class SecondBlogController : Controller
    {
        private TempContext db = new TempContext();

        // GET: Admin/SecondBlog
        public ActionResult Index()
        {
            return View(db.SecondBlogs.ToList());
        }

        // GET: Admin/SecondBlog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondBlog secondBlog = db.SecondBlogs.Find(id);
            if (secondBlog == null)
            {
                return HttpNotFound();
            }
            return View(secondBlog);
        }

        // GET: Admin/SecondBlog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SecondBlog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,Title,Name,DataTime,News,Text")] SecondBlog secondBlog)
        {
            if (ModelState.IsValid)
            {
                db.SecondBlogs.Add(secondBlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondBlog);
        }

        // GET: Admin/SecondBlog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondBlog secondBlog = db.SecondBlogs.Find(id);
            if (secondBlog == null)
            {
                return HttpNotFound();
            }
            return View(secondBlog);
        }

        // POST: Admin/SecondBlog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image,Title,Name,DataTime,News,Text")] SecondBlog secondBlog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondBlog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondBlog);
        }

        // GET: Admin/SecondBlog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondBlog secondBlog = db.SecondBlogs.Find(id);
            if (secondBlog == null)
            {
                return HttpNotFound();
            }
            return View(secondBlog);
        }

        // POST: Admin/SecondBlog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondBlog secondBlog = db.SecondBlogs.Find(id);
            db.SecondBlogs.Remove(secondBlog);
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
