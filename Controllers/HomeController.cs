﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPaneNew.Areas.OfficialAdmin.Models;

namespace ApexIelts.Controllers
{
    public class HomeController : Controller
    {
        dbcontext db = new dbcontext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult CompanyOverview()
        {
            Pages pp = db.Pages.Where(x => x.Pagesid == 2).FirstOrDefault();
            return View(pp);
        }
        public ActionResult FounderMessage()
        {
            Pages pp = db.Pages.Where(x => x.Pagesid == 3).FirstOrDefault();
            return View(pp);
        }
        public ActionResult WhyChooseUs()
        {
            Pages pp = db.Pages.Where(x => x.Pagesid == 4).FirstOrDefault();
            return View(pp);
        }
        public ActionResult OurMission()
        {
            Pages pp = db.Pages.Where(x => x.Pagesid == 5).FirstOrDefault();
            return View(pp);
        }
        public ActionResult OurVision()
        {
            Pages pp = db.Pages.Where(x => x.Pagesid == 6).FirstOrDefault();
            return View(pp);
        }
        public ActionResult Service(int id)
        {
            Service ss = db.Services.Where(x => x.Serviceid == id).FirstOrDefault();
            return View(ss);
        }
        public ActionResult ServiceDetails(int id)
        {
            SingleService sser = db.SingleServices.Where(x => x.Singleid == id).FirstOrDefault();
            return View(sser);
        }
      
        public ActionResult ShiningStars()
        {
            return View();
        }
        public ActionResult Albums()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            Contact cc = db.Contacts.ToList().FirstOrDefault();
            return View(cc);
            //return View();
        }
        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Test()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}