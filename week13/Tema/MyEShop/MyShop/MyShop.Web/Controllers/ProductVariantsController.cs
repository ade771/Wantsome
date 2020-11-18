using MyShop.Data.Models;
using MyShop.Data.Services;

using System.Linq;
using System.Web.Mvc;

namespace ClothingShop.Web.Controllers
{
    public class ProductVariantsController : Controller
    {

        readonly IClothingData<ProductVariant> db;
        public ProductVariantsController()
        {
            db = new InMemoryClothingDataProductVariant();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.ProductVariants.Add(value);
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
        public ActionResult Create(ProductVariant productVariant)
        {
            if (ModelState.IsValid)
            {
                db.Add(productVariant);
                return RedirectToAction("Details", new { id = productVariant.ProductVariant_Id });
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
        public ActionResult Edit(ProductVariant productVariant)
        {
            if (ModelState.IsValid)
            {
                db.Update(productVariant);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = productVariant.ProductVariant_Id });
            }
            return View(productVariant);
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