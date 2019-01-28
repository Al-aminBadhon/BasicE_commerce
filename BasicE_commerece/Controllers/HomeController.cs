using BasicE_commerece.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace BasicE_commerece.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        basicE_commerceEntities2 db = new basicE_commerceEntities2();
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }
        [HttpGet]
        public ActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd([Bind(Include = "Name,Description,Image,Stock,Price")]Product product, HttpPostedFileBase image1)
        {
         

            if (image1 != null)
            {
            string imagename = Path.GetFileNameWithoutExtension(image1.FileName);
            string extension = Path.GetExtension(image1.FileName);
            imagename = imagename + DateTime.Now.ToString("yymmssfff") + extension;
            product.Image = "~/Image/" + imagename;
            imagename = Path.Combine(Server.MapPath("~/Image/"), imagename);
            image1.SaveAs(imagename);


                if (ModelState.IsValid)
                {


                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Product");
                }
                }



            return View();
        }
        public ActionResult Slider()
        {
            return View(db.Sliders.ToList());
        }

        public ActionResult Comment()
        {
            return View(db.Comments.ToList());
        }


        //test 
        public ActionResult Test()
        {
            return View();
        }
    }

}