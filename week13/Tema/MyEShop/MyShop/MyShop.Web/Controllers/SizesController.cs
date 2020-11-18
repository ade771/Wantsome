using MyShop.Data.Models;
using MyShop.Data.Services;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class SizesController : Controller
    {

        readonly IClothingData<Size> db;
        public SizesController()
        {
            db = new InMemoryClothingDataSize();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.Sizes.Add(value);
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
        public ActionResult Create(Size size)
        {
            if (ModelState.IsValid)
            {
                db.Add(size);
                return RedirectToAction("Details", new { id = size.Size_id });
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
        public ActionResult Edit(Size size)
        {
            if (ModelState.IsValid)
            {
                db.Update(size);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = size.Size_id });
            }
            return View(size);
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