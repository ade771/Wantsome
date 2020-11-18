using MyShop.Data.Models;
using MyShop.Data.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class SubcategoriesController : Controller
    {



        readonly IClothingData<Subcategory> db;
        public SubcategoriesController()
        {
            db = new InMemoryClothingDataSubcategory();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.Subcategories.Add(value);
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
        public ActionResult Create(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.Add(subcategory);
                return RedirectToAction("Details", new { id = subcategory.Subcategory_id });
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
        public ActionResult Edit(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.Update(subcategory);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = subcategory.Subcategory_id });
            }
            return View(subcategory);
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