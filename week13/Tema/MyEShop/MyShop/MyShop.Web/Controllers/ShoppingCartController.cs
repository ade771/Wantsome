using MyShop.Data.Models;
using MyShop.Data.Services;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        ShopDbContext ctx = new ShopDbContext();
        public ActionResult Index()
        {

            var cart = new CartModel();

            var model = new ShoppingCartModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            return View(model);

        }

        public ActionResult Buy(int id)
        {
            var addedproduct = ctx.ProductPhotos.Single(p => p.Photo_id == id);
            var cart = CartModel.GetCart();
            cart.AddToCart(addedproduct);
            return RedirectToAction("Index");
        }
    }

}