using MyShop.Data.Models;
using MyShop.Data.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class ProductPhotoesController : Controller
    {
        readonly IClothingData<ProductPhoto> db;
        public ProductPhotoesController()
        {
            db = new InMemoryClothingDataProductPhoto();
            
        }
        public ActionResult Index()
        {

            InMemoryClothingDataProductPhoto db1 = new InMemoryClothingDataProductPhoto();


              ViewBag.productPhoto = db1.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{
            //    foreach (var value in ViewBag.productPhoto)
            //    {

            //        ctx.ProductPhotos.Add(value);
            //    }
            //    ctx.SaveChanges();
            //}
            return View();
            
               
         }
        
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductPhoto productPhoto)
        {
            if (ModelState.IsValid)
            {
                db.Add(productPhoto);
                return RedirectToAction("Details", new { id = productPhoto.Photo_id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductPhoto productPhoto)
        {
            if (ModelState.IsValid)
            {
                db.Update(productPhoto);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = productPhoto.Photo_id });
            }
            return View(productPhoto);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}