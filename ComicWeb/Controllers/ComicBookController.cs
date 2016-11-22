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
            ViewBag.Description = "bla bla bla bla bla bla bla";
            ViewBag.HtmlEscape = "<p>hola esto es un parrafo html pero q troll vs escapo</p>";
            ViewBag.HtmlEscapado = "<p>hola esto es un parrafo html con html raw q no escapa</p>";
            ViewBag.Artists = new string[]
                {
                "algo: esto",
                "esto mas: de esto",
                "y por ultim: esto"
                };
            return View();

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{
            //    return Redirect("/");
            //    ////return new RedirectResult("/");
            //}

            //return Content("yeah");
            ////return new ContentResult()
            ////{
            ////        Content = "Yeah"
            ////};
        }
    }
}