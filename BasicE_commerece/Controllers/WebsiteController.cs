﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicE_commerece.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: Website
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HomeView()
        {
            return View();
        }
    }
}