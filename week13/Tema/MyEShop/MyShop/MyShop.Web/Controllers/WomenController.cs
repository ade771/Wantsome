using MyShop.Data.Services;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class WomenController : Controller
    {
        // GET: WoPeople
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Accessories()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Accessories" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Bags()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Bags" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);

            }
        }
        public ActionResult Body()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Body" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Dresses()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Dresses" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }



        public ActionResult Jeans()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Jeans" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Jumpsuits()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Jumpsuits" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Shoes()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Shoes" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Skirts()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Skirts" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult Swimwear()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "Swimwear" && p.ProductId > 29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
        public ActionResult TShirts()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Subcategories,
                        product => product.Subcategory.Subcategory_id,
                        productp => productp.Subcategory_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            SubName = productp.Name,
                            Sub_id = productp.Subcategory_id,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            SubcategoryName = product.SubName,
                            Subcategory_id = product.Sub_id,
                            ProductName = product.ProductName,
                            ProductSource = products.Source,
                            PhotoId = products.Product_id
                        })

                    .Join(
                        context.Prices,
                        product => product.Product_Id,
                        price => price.Price_id,
                        (product, price) => new
                        {
                            ProductId = product.Product_Id,
                            SubName = product.SubcategoryName,
                            Subcategory_Id = product.Subcategory_id,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).Where(p => p.SubName == "T-Shirts" && p.ProductId >29 && p.ProductId < 69).ToList();
                PeopleClothing model = new PeopleClothing();
                model.people = data.Select(p => new People
                {

                    Name = p.Name,
                    Source = p.Source,
                    Photo_id = p.Photo_id,
                    Price = p.NetPrice,
                    Discount = p.ProductDiscount
                });
                return View(model);
            }
        }
    }
}
 
