using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lektion35.Controllers
{
    public class HomeController : Controller
    {
        // change
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP___NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
