using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.Security;
using booktest.Models;
using System.Net;
using System.Data.Entity.Infrastructure;

namespace booktest.Controllers
{
    public class HomeController : Controller
    {
       
        private PeopleDBcontext db = new PeopleDBcontext();
        // GET: LogIn
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult LogIn()
        {
            return View();

        }


        [HttpPost]
        public ActionResult LogIn(string UserName, string Password)
        {
            string ID = UserName;
            Person p = db.persons.Find(ID);
            if (UserName == null)
            {
                ModelState.AddModelError("Error", "请输入用户名！");
                return View();
            }

            if (UserName != p.ID || Password != p.Password)
            {
                ModelState.AddModelError("Error", "用户名或密码错误");
                return View();
            }
            if (UserName == p.ID && UserName == p.Password)
            {
                if (p.Administrator == true)
                {
                    return Redirect("/BookManagement/Index");
                }

                else { return Redirect("/ChangeSituation"); }


            }

            return View();
        }
    }
}