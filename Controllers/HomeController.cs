using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoneBridge_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult OurTeam()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TESTIMONIALS()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact_New()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}