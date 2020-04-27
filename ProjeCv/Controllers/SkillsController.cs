using ProjeCv.Models;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class SkillsController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Skills
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.skills = db.TblSkills.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Ekle(TblSkills t)
        {
            db.TblSkills.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var del = db.TblSkills.Find(id);
            db.TblSkills.Remove(del);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult List(int id)
        {
            var li = db.TblSkills.Find(id);
            return View(li);
        }

        public ActionResult Edit(TblSkills p)
        {
            var dd = db.TblSkills.Find(p.Id);
            dd.Skill = p.Skill;
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}