using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjectTest.Interface;

namespace NinjectTest.Controllers
{
    public class HomeController : Controller
    {
        readonly IEvent someEvent;

        public HomeController(IEvent someEvent)
        {
            this.someEvent = someEvent;
        }
        public ActionResult Index()
        {
            var x = someEvent.GetAll();
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