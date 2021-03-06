﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using booktest.Models;
using System.Net;
using System.Data.Entity.Infrastructure;

namespace booktest.Controllers
{
    public class SituationController : Controller
    {
        private booktest.Models.Database db = DatabaseContext.GetInstance();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult Situation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Situation(string Name)
        {
            Borrow BorrowSituation = db.Borrow.FirstOrDefault( o => o.Book.LookUp==Name);
            if (Name == null)
            {
                return HttpNotFound();
            }
            return View(BorrowSituation);
        }

    }
}