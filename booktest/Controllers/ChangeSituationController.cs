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
    public class ChangeSituationController : Controller
    {
        private BooksDBContext db = new BooksDBContext();

        // GET: ChangeSituation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeSituation()
        {
            return View();
        }

        public ActionResult BorrowBook(int?ID)
        {
            Book book = db.Books.Find(ID);

            if (book.Situation== true)
            {
                book.Situation = false;
                Console.WriteLine("借书成功");
            }
            return View(book);
        }

        public ActionResult ReturnBook(int? ID)
        {
            Book book = db.Books.Find(ID);

            if (book.Situation == false)
            {
                book.Situation = true;
                Console.WriteLine("还书成功");
            }
            return View(book);
        }

    }
}