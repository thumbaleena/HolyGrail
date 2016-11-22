using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstASPapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who are we?";

            ViewBag.HelloMessage = "I thought we were an autonomous collective";
  //          ViewData.Add("HelloMessage", "Hello from GC");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Just kidding.  No one here but Tim the Enchanter.";

            return View();
        }

    }
}