using MyShop.Data.Models;
using MyShop.Data.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class ProductsController : Controller
    {


        readonly IClothingData<Product> db;
        public ProductsController()
        {
            db = new InMemoryClothingDataProduct();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.Products.Add(value);
            //    }
            //    ctx.SaveChanges();
            //}

            return View(model);
            
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
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Add(product);
                return RedirectToAction("Details", new { id = product.Category_id });
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
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Update(product);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = product.Product_id });
            }
            return View(product);
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