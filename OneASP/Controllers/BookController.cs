using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneASP.Models;

namespace OneASP.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Create()
        {
            return View(new Book { ReleasedDate = DateTime.Now });
        }

        [HttpPost]
        [ActionName("CreateWithRequest")]
        public ActionResult CreatePost(Book model)
        {
            if (ModelState.IsValid) { }
            return View();
        }
    }
}