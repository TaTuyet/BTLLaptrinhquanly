using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;
namespace BaiTapLonLTQL.Controllers
{
    public class ChiTietMuaController : Controller
    {
        private Model1 db = new Model1();
        // GET: ChiTietMua
        public ActionResult Index()
        {
            return View(db.ChiTietMuas.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ChiTietMua ctm)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietMuas.Add(ctm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string soHdm,string maHanghoa)
        {
            ChiTietMua ctm = db.ChiTietMuas.Find(soHdm,maHanghoa);
            return View(ctm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChiTietMua ctm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ctm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ctm);
        }
        public ActionResult Delete(string soHdm, string maHanghoa)
        {
            ChiTietMua ctm = db.ChiTietMuas.Find(soHdm, maHanghoa);
            return View(ctm);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string soHdm, string maHanghoa)
        {
            ChiTietMua ctm = db.ChiTietMuas.Find(soHdm,maHanghoa);
            db.ChiTietMuas.Remove(ctm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}