using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var nmbrofDivision = db.Divisions.Count();
            var nmbrofDept = db.Depts.Count();
            var nmbrofSection = db.Sections.Count();
            var nmbrofDesignation = db.Designations.Count();
            var nmbrofEmployee = db.Employees.Count();

            ViewBag.nmbrofDivision = nmbrofDivision;
            ViewBag.nmbrofDept = nmbrofDept;
            ViewBag.nmbrofSection = nmbrofSection;
            ViewBag.nmbrofDesignation = nmbrofDesignation;
            ViewBag.nmbrofEmployee = nmbrofEmployee;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}