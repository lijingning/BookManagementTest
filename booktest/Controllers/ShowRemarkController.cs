using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using booktest.Models;
using System.Net;
using System.Data.Entity.Infrastructure;

namespace booktest.Controllers
{
    public class ShowRemarkController : Controller
    {
        private booktest.Models.Database db = DatabaseContext.GetInstance();

        // GET: ShowRemark
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowRemark()
        {
            return View(db.Remarks.ToList());
        }

    }
}