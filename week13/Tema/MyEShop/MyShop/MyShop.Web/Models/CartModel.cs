using MyShop.Data.Models;
using MyShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyShop.Web.Models
{
    public class CartModel
    {
        ShopDbContext storeDB = new ShopDbContext();
        int ShoppingCartId { get; set; }

        public static CartModel GetCart()
        {
            var cart = new CartModel();
            cart.ShoppingCartId = new Random().Next(1, 1000);
            return cart;

        }

        public void AddToCart(ProductPhoto product)
        {
            var cartItem = storeDB.Carts.SingleOrDefault(c => c.CartId == ShoppingCartId && c.Photo_id == product.Photo_id);

            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    Photo_id = product.Photo_id,
                    CartId = ShoppingCartId,
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };
                storeDB.Carts.Add(cartItem);
            }
            else
            {

                cartItem.Quantity++;
            }
            storeDB.SaveChanges();
        }
        public List<Cart> GetCartItems()
        {
            return storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId).ToList();
        }
        public int RemoveFromCart(int id)
        {

            var cartItem = storeDB.Carts.Single(
                cart => cart.CartId == ShoppingCartId);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    itemCount = cartItem.Quantity;
                }
                else
                {
                    storeDB.Carts.Remove(cartItem);
                }
                storeDB.SaveChanges();
            }
            return itemCount;
        }

        public double GetTotal()
        {
            using (var context = new ShopDbContext())
            {
                var data = context.Products
                    .Join(
                        context.Carts,
                        product => product.Product_id,
                        productp => productp.Photo_id,
                        (product, productp) => new
                        {
                            ProductId = product.Product_id,
                            Quantity = productp.Quantity,
                            ProductName = product.Name,
                        })
                    .Join(
                        context.ProductPhotos,
                        product => product.ProductId,
                        products => products.Product_id,
                        (product, products) => new
                        {
                            Product_Id = product.ProductId,
                            PQuantity = product.Quantity,
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
                            Quantity = product.PQuantity,
                            Name = product.ProductName,
                            Source = product.ProductSource,
                            Photo_id = product.PhotoId,
                            NetPrice = price.Net_price,
                            ProductDiscount = price.Discount
                        }).ToList();
                double total = (from cartItems in data
                                select cartItems.Quantity *
                                cartItems.NetPrice - (cartItems.ProductDiscount / 100 * cartItems.NetPrice * cartItems.Quantity)).Sum();

                return total;
            }
        }
    }

}
