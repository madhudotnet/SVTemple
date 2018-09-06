using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVTemple.Controllers
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
        public ActionResult Charity()
        {
            ViewBag.Message = "Your Charity page.";

            return View();
        }
        public ActionResult History()
        {
            ViewBag.Message = "Your History page.";

            return View();
        }
        public ActionResult Events()
        {
            ViewBag.Message = "Your Events page.";

            return View();
        }
    }
}