﻿using System;
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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }

            return Content("yeah");
            //return new ContentResult()
            //{
            //        Content = "Yeah"
            //};
        }
    }
}