using MyShop.Data.Models;
using MyShop.Data.Services;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new ShopDbContext())
            {
                var allproduct = context.Products
                    .Join(
                        context.ProductPhotos,
                        product => product.Product_id,
                        productp => productp.Product.Product_id,
                        (product, productp) => new
                        {
                            Product_Id = product.Product_id,
                            ProductName = product.Name,
                            ProductSource = productp.Source,
                            PhotoId = productp.Product_id
                        }
                    )
                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).ToList();
                HomeModel model = new HomeModel { };

                model.products = allproduct.Select(p => new ProductModel
                {
                    Product_id = p.ProductId,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Name = p.Name,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount


                }).Take<ProductModel>(25);
                return View(model);

            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
       

    }
    }



