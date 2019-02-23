using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Change(String LanguageAbbrevation)
        {
            if (LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);
            }

            HttpCookie cookie = new HttpCookie("language");
            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
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
        public ActionResult Vizyondakiler()
        {
            ViewBag.Message = "Vizyon";

            return View();
        }
        public ActionResult Eniyi()
        {
            ViewBag.Message = "eniyi";

            return View();
        }
              
            
        public ActionResult OrnekFilm()
        {
            ViewBag.Message = "sdas";

            return View();
        }
    }
}