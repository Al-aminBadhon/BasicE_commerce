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

        basicE_commerceEntities3 db = new basicE_commerceEntities3();
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            List<Product> products = db.Products.ToList();
            ViewBag.Products = products;

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
            product.Image = "/Image/" + imagename;
            imagename = Path.Combine(Server.MapPath("~/Image/"), imagename);
            image1.SaveAs(imagename);

                db.Products.Add(product);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Product");
                
            }



            return View();
        }
        
        public ActionResult Slider()
        {
            return View(db.Sliders.ToList());
        }
        [HttpGet]
        public ActionResult SliderAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SliderAdd([Bind(Include = "Name,Image,SliderText,IsActive")] Slider slider, Slider imagemodel)
        {
            if (imagemodel != null)
            {
                String fileName = Path.GetFileNameWithoutExtension(imagemodel.ImageFile.FileName);
                String extension = Path.GetExtension(imagemodel.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                slider.Image = "~/Image/" + imagemodel;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                imagemodel.ImageFile.SaveAs(fileName);

                db.Sliders.Add(slider);

                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Slider");
            }
            return View();
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