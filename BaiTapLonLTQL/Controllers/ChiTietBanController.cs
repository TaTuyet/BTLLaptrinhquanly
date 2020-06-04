using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class ChiTietBanController : Controller
    {
        private Model1 db = new Model1();
        // GET: ChiTietBan
        public ActionResult Index()
        {
            return View(db.ChiTietBans.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ChiTietBan ctb)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietBans.Add(ctb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string soHdb, string maHanghoa)
        {
            ChiTietBan ctb = db.ChiTietBans.Find(soHdb, maHanghoa);
            return View(ctb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChiTietBan ctb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ctb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ctb);
        }
        public ActionResult Delete(string soHdb, string maHanghoa)
        {
            ChiTietBan ctb = db.ChiTietBans.Find(soHdb, maHanghoa);
            return View(ctb);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string soHdb, string maHanghoa)
        {
            ChiTietBan ctb = db.ChiTietBans.Find(soHdb, maHanghoa);
            db.ChiTietBans.Remove(ctb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}