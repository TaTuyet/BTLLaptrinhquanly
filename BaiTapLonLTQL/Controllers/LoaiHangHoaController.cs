using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using BaiTapLonLTQL.Models;

namespace BaiTapLonLTQL.Controllers
{
    public class LoaiHangHoaController : Controller
    {
        private Model1 db = new Model1();
        // GET: LoaiHangHoa
        public ActionResult Index()
        {
            return View(db.LoaiHangHoas.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(LoaiHangHoa lhh)
        {
            if (ModelState.IsValid)
            {
                db.LoaiHangHoas.Add(lhh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            LoaiHangHoa lhh = db.LoaiHangHoas.Find(id);
            return View(lhh);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LoaiHangHoa lhh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lhh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lhh);
        }
        public ActionResult Delete(string id)
        {
            LoaiHangHoa lhh = db.LoaiHangHoas.Find(id);
            return View(lhh);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            LoaiHangHoa lhh = db.LoaiHangHoas.Find(id);
            db.LoaiHangHoas.Remove(lhh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}