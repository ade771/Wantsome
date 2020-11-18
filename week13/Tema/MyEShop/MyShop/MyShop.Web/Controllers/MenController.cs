using MyShop.Data.Models;
using MyShop.Data.Services;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Controllers
{
    public class MenController : Controller
    {
       
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
                        }).Where(p => p.SubName == "Accessories" && p.ProductId < 30).ToList();
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
        public ActionResult Backpacks()
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
                        }).Where(p => p.SubName == "Backpacks" && p.ProductId < 30).ToList();
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
            public ActionResult Blazers()
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
                            }).Where(p => p.SubName == "Blazers" && p.ProductId < 30).ToList();
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
        public ActionResult Jackets()
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
                        }).Where(p => p.SubName == "Jackets" && p.ProductId < 30).ToList();
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
                        }).Where(p => p.SubName == "Jeans" && p.ProductId < 30).ToList();
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
        public ActionResult Shirts()
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
                        }).Where(p => p.SubName == "Shirts" && p.ProductId < 30).ToList();
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
                        }).Where(p => p.SubName == "Shoes" && p.ProductId < 30).ToList();
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
                        }).Where(p => p.SubName == "T-Shirts" && p.ProductId < 30).ToList();
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
        public ActionResult Underwear()
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
                        }).Where(p => p.SubName == "Underwear" && p.ProductId < 30).ToList();
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
