using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using booktest.Models;

namespace booktest.Controllers
{
    public class AddRemarkController : Controller
    {
        private booktest.Models.Database db = DatabaseContext.GetInstance();

        // GET: AddRemark
        public ActionResult Index()
        {
            return View(db.Remarks.ToList());
        }
        public ActionResult AddRemark()
        {
            return View();
        }

        public ActionResult AddRemark(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            return View(remark);
        }

        // GET: AddRemark/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddRemark/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Content,Date")] Remark remark)
        {
            if (ModelState.IsValid)
            {
                db.Remarks.Add(remark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(remark);
        }

        // GET: AddRemark/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            return View(remark);
        }

        // POST: AddRemark/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Content,Date")] Remark remark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(remark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(remark);
        }

        // GET: AddRemark/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            return View(remark);
        }

        // POST: AddRemark/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Remark remark = db.Remarks.Find(id);
            db.Remarks.Remove(remark);
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
