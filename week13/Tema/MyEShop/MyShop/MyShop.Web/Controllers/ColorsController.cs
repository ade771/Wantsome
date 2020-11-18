
using MyShop.Data.Models;
using System.Linq;
using System.Web.Mvc;



namespace MyShop.Web.Controllers
{
    public class ColorsController : Controller

    {
        readonly IClothingData<Color> db;

        public ColorsController()
        {
            db = new InMemoryClothingDataColor();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            //using (var ctx = new ClothingShopDbContext())
            //{

            //    foreach (var value in model)
            //    {

            //        ctx.Colors.Add(value);
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
        public ActionResult Create(Color color)
        {
            if (ModelState.IsValid)
            {
                db.Add(color);
                return RedirectToAction("Details", new { id = color.Color_id });
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
        public ActionResult Edit(Color color)
        {
            if (ModelState.IsValid)
            {
                db.Update(color);
                TempData["Message"] = "You have saved the category!";
                return RedirectToAction("Details", new { id = color.Color_id });
            }
            return View(color);
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
