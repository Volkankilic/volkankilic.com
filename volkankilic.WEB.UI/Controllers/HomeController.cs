using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace volkankilic.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult searchBar()
        {
            return PartialView("~/Views/PartialViews/_searchBar.cshtml");
        }

        public PartialViewResult contents()
        {
            return PartialView("~/Views/PartialViews/_contents.cshtml");
        }

        public PartialViewResult coffeeBox()
        {
            return PartialView("~/Views/PartialViews/_coffeeBox.cshtml");
        }
    }
}