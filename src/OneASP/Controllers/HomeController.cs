using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneASP.Models;

namespace OneASP.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Test()
        {
            var query = new Books();
            return View(query.ToList());
        }

        public ActionResult Index()
        {

            return Json(new { Name = "Sirwan", LastName = "Afifi" }, JsonRequestBehavior.AllowGet);
        }

        public void MinimalAction()
        {
            Response.Write("Hello guys!");
            Response.End();
        }
    }
}