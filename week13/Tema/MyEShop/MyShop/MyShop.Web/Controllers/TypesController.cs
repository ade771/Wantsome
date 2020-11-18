using MyShop.Data.Models;
using MyShop.Data.Services;

using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class TypesController : Controller
    {
        readonly IClothingData<ProductType> db;
        public TypesController()
        {
           db = new InMemoryClothingDataProductType();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.ProductTypes.Add(value);
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
        public ActionResult Create(ProductType productType)
        {
            if (ModelState.IsValid)
            {
                db.Add(productType);
                return RedirectToAction("Details", new { id = productType.Type_id });
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
        public ActionResult Edit(ProductType productType)
        {
            if (ModelState.IsValid)
            {
                db.Update(productType);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = productType.Type_id });
            }
            return View(productType);
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