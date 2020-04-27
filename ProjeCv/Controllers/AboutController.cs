using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models;

namespace ProjeCv.Controllers
{
    public class AboutController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: About
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.about = db.TblAbout.ToList();
            return View(cs);
        }

        public ActionResult List(int id)
        {
            var li = db.TblAbout.Find(id);
            return View(li);
        }

        public ActionResult Edit(TblAbout p)
        {
            var dt = db.TblAbout.Find(p.Id);
            dt.Name = p.Name;
            dt.Surname = p.Surname;
            dt.Address = p.Address;
            dt.Phone = p.Phone;
            dt.Email = p.Email;
            dt.About = p.About;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}