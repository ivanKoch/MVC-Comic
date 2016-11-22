using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicWeb.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Este es el titulo";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>hola esto es un parrafo html pero q troll vs escapo</p>";
            ViewBag.Artists = new string[]
                {
                "algo: esto",
                "esto mas: de esto",
                "y por ultim: esto"
                };
            return View();
        }
    }
}