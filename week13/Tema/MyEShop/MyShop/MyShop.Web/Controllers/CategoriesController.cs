
using MyShop.Data.Models;
using MyShop.Data.Services;
using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class CategoriesController: Controller
    {
        readonly IClothingData<Category> db;

        public CategoriesController()
        {
            db = new InMemoryClothingDataCategory();
        }

        public ActionResult Index()
        {
            var list = db.GetAll();
            //using (var ctx = new ShopDbContext())
            //{

            //    foreach (var value in list)
            //    {

            //        ctx.Categories.Add(value);
            //    }
            //    ctx.SaveChanges();
                return View(list);
           // }

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
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Add(category);
                return RedirectToAction("Details", new { id = category.Category_id });
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
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Update(category);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = category.Category_id });
            }
            return View(category);
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

