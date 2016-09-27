using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities.Models;
using ContosoUniversity.ViewModels;
using Entities.Context;

namespace Entities.Controllers
{
    public class HomeController : Controller
    {
        SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from std in db.Students
                                                   group std by std.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}