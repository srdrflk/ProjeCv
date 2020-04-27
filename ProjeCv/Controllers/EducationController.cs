using ProjeCv.Models;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class EducationController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Education
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.edu = db.TblEducation.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ekle(TblEducation p)
        {
            db.TblEducation.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var del = db.TblEducation.Find(id);
            db.TblEducation.Remove(del);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult List(int id)
        {
            var li = db.TblEducation.Find(id);

            return View(li);
        }

        public ActionResult Edit(TblEducation t)
        {
            var d = db.TblEducation.Find(t.Id);
            d.Title = t.Title;
            d.Subtitle = t.Subtitle;
            d.Date = t.Date;
            d.Department = t.Department;
            d.GPA = t.GPA;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}