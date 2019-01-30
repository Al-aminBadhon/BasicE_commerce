using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using BasicE_commerece.Models;

namespace BasicE_commerece.Controllers
{
    public class WebsiteController : Controller
    {

        // GET: Website
        basicE_commerceEntities3 db = new basicE_commerceEntities3();

        public ActionResult Index()
        {

            return View(db.Products.ToList());
        }
        public ActionResult HomeView()
        {
            return View();
        }
    }
}