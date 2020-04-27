using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models;

namespace ProjeCv.Controllers
{
    public class DefaultController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Default
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.about = db.TblAbout.ToList();
            cs.exp = db.TblExperience.ToList();
            cs.edu = db.TblEducation.ToList();
            cs.awards = db.TblAwards.ToList();
            cs.interest = db.TblInterests.ToList();
            cs.skills = db.TblSkills.ToList();
            return View(cs);

            //var about = db.TblAbout.ToList();
            //return View(about);
        }
    }
}