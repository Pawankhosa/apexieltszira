﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPaneNew.Areas.OfficialAdmin.Models;

namespace AdminPaneNew.Areas.OfficialAdmin.Controllers
{
    public class CountersController : Controller
    {
        private dbcontext db = new dbcontext();

        // GET: OfficialAdmin/Counters
        public ActionResult Index()
        {
            return View(db.Counters.ToList());
        }

        // GET: OfficialAdmin/Counters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counters.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // GET: OfficialAdmin/Counters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficialAdmin/Counters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Counterid,Experience,Customers,date,Award,Satisfied")] Counter counter)
        {
            if (ModelState.IsValid)
            {
                counter.date = System.DateTime.Now;
                db.Counters.Add(counter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(counter);
        }

        // GET: OfficialAdmin/Counters/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counters.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // POST: OfficialAdmin/Counters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Counterid,Experience,Customers,date,Award,Satisfied")] Counter counter)
        {
            if (ModelState.IsValid)
            {
                counter.date = System.DateTime.Now;
                db.Entry(counter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(counter);
        }

        // GET: OfficialAdmin/Counters/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counters.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // POST: OfficialAdmin/Counters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Counter counter = db.Counters.Find(id);
            db.Counters.Remove(counter);
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
