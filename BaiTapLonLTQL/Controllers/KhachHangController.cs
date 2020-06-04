using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
   
    public class KhachHangController : Controller
    {
        private Model1 db = new Model1();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View(db.KhachHangs.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            KhachHang kh = db.KhachHangs.Find(id);
            return View(kh);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kh);
        }
        public ActionResult Delete(string id)
        {
            KhachHang kh = db.KhachHangs.Find(id);
            return View(kh);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            KhachHang kh = db.KhachHangs.Find(id);
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}