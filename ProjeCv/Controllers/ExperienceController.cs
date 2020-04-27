using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models;

namespace ProjeCv.Controllers
{
    public class ExperienceController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Experience
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.exp = db.TblExperience.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ekle(TblExperience p)
        {
            db.TblExperience.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var del = db.TblExperience.Find(id);
            db.TblExperience.Remove(del);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult List(int id)
        {
            var li = db.TblExperience.Find(id);
            return View(li);
        }

        public ActionResult Edit(TblExperience p)
        {
            var dd = db.TblExperience.Find(p.Id);
            dd.Title = p.Title;
            dd.Subtitle = p.Subtitle;
            dd.Date = p.Date;
            dd.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}