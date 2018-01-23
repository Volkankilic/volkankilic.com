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

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Sorular()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        #region PartialViews
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
        public PartialViewResult mostRead()
        {
            return PartialView("~/Views/PartialViews/_mostRead.cshtml");
        }
        public PartialViewResult mostCommented()
        {
            return PartialView("~/Views/PartialViews/_mostCommented.cshtml");
        }
        public PartialViewResult lastQuestions()
        {
            return PartialView("~/Views/PartialViews/_lastQuestions.cshtml");
        }
        public PartialViewResult contentDetail()
        {
            return PartialView("~/Views/PartialViews/_contentDetail.cshtml");
        }
        
        public PartialViewResult trainingSets()
        {
            return PartialView("~/Views/PartialViews/_trainingSets.cshtml");
        }
        #endregion

    }
}