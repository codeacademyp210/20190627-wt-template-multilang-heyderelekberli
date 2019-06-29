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
    public class AbilityController : Controller
    {
        private TempContext db = new TempContext();

        // GET: Admin/Ability
        public ActionResult Index()
        {
            return View(db.Abilities.ToList());
        }

        // GET: Admin/Ability/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ability ability = db.Abilities.Find(id);
            if (ability == null)
            {
                return HttpNotFound();
            }
            return View(ability);
        }

        // GET: Admin/Ability/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Ability/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Number,Title,Text")] Ability ability)
        {
            if (ModelState.IsValid)
            {
                db.Abilities.Add(ability);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ability);
        }

        // GET: Admin/Ability/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ability ability = db.Abilities.Find(id);
            if (ability == null)
            {
                return HttpNotFound();
            }
            return View(ability);
        }

        // POST: Admin/Ability/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Number,Title,Text")] Ability ability)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ability).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ability);
        }

        // GET: Admin/Ability/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ability ability = db.Abilities.Find(id);
            if (ability == null)
            {
                return HttpNotFound();
            }
            return View(ability);
        }

        // POST: Admin/Ability/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ability ability = db.Abilities.Find(id);
            db.Abilities.Remove(ability);
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
