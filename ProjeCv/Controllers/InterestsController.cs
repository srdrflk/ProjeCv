using ProjeCv.Models;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class InterestsController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Interests
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.interest = db.TblInterests.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ekle(TblInterests t)
        {
            db.TblInterests.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var del = db.TblInterests.Find(id);
            db.TblInterests.Remove(del);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult List(int id)
        {
            var li = db.TblInterests.Find(id);
            return View(li);
        }

        public ActionResult Edit(TblInterests p)
        {
            var dd = db.TblInterests.Find(p.Id);
            dd.Interest = p.Interest;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}