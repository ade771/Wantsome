using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class ShoppingCartModel
    {
        public List<Cart> CartItems { get; set; }
        public double CartTotal { get; set; }
    }
}