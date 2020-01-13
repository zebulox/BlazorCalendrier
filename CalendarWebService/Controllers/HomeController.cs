using CalendarWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalendarWebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (CalendrierContext db = new CalendrierContext())
            {
                List<Note> Notes = db.Notes.Where(n => true).ToList();
            }

            return View();
        }
    }
}
