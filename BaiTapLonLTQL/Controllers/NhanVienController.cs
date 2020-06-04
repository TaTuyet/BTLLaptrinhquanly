using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class NhanVienController : Controller
    {
        private Model1 db = new Model1();
        // GET: NhanVien
        public ActionResult Index()
        {
            return View(db.NhanViens.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            return View(nv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nv);
        }
        public ActionResult Delete(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            return View(nv);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}