using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class HDMuaController : Controller
    {
        private Model1 db = new Model1();
        // GET: HDMua
        public ActionResult Index()
        {
            return View(db.HDMuas.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HDMua hdm)
        {
            if (ModelState.IsValid)
            {
                db.HDMuas.Add(hdm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            HDMua hdm = db.HDMuas.Find(id);
            return View(hdm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HDMua hdm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hdm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hdm);
        }
        public ActionResult Delete(string id)
        {
            HDMua hdm = db.HDMuas.Find(id);
            return View(hdm);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            HDMua hdm = db.HDMuas.Find(id);
            db.HDMuas.Remove(hdm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}