using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class NhaCungCapController : Controller
    {
        private Model1 db = new Model1();
        // GET: NhaCungCap
        public ActionResult Index()
        {
            return View(db.NhaCungCaps.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhaCungCap ncc)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCaps.Add(ncc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(id);
            return View(ncc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NhaCungCap ncc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ncc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ncc);
        }
        public ActionResult Delete(string id)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(id);
            return View(ncc);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(id);
            db.NhaCungCaps.Remove(ncc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}