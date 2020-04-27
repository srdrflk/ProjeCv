using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models;

namespace ProjeCv.Controllers
{
    public class AwardsController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Awards
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.awards = db.TblAwards.ToList();

            return View(cs);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ekle(TblAwards a)
        {
            db.TblAwards.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var del = db.TblAwards.Find(id);
            db.TblAwards.Remove(del);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult List(int id)
        {
            var li = db.TblAwards.Find(id);
            return View(li);
        }

        public ActionResult Edit(TblAwards p)
        {
            var dt = db.TblAwards.Find(p.Id);
            dt.Award = p.Award;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}