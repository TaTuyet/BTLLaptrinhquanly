using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class HDBanController : Controller
    {
        private Model1 db = new Model1();
        // GET: HDBan
        public ActionResult Index()
        {
            return View(db.HDBans.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HDBan hdb)
        {
            if (ModelState.IsValid)
            {
                db.HDBans.Add(hdb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            HDBan hdb = db.HDBans.Find(id);
            return View(hdb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HDBan hdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hdb);
        }
        public ActionResult Delete(string id)
        {
            HDBan hdb = db.HDBans.Find(id);
            return View(hdb);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            HDBan hdb = db.HDBans.Find(id);
            db.HDBans.Remove(hdb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}