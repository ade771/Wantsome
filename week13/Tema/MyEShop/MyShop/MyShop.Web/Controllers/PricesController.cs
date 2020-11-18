using MyShop.Data.Models;
using MyShop.Data.Services;

using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class PricesController : Controller
    {
        readonly IClothingData<Price> db;
        public PricesController()
        {
            db = new InMemoryClothingDataPrice();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.Prices.Add(value);
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
        public ActionResult Create(Price price)
        {
            if (ModelState.IsValid)
            {
                db.Add(price);
                return RedirectToAction("Details", new { id = price.Price_id });
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
        public ActionResult Edit(Price price)
        {
            if (ModelState.IsValid)
            {
                db.Update(price);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = price.Price_id });
            }
            return View(price);
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