using ComicWeb.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The amazing spider man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Descripción con html para usar raw.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Role = "Script", Name = "Elba Gallo" },
                    new Artist() { Role = "Pencils", Name = "Ramon Gutierrez" },
                    new Artist() { Role = "Inks", Name = "Victor Olazabal" },
                    new Artist() { Role = "Colors", Name = "Edgar Delgado" },
                    new Artist() { Role = "Letters", Name = "Chris Eliopoulos" }
                }
            };
            // alternativamente comicBook.SeriesTitle = "";

            return View(comicBook);
        }
    }
}