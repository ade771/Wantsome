using MyShop.Data.Models;
using MyShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class ProductModel
    {
        public int Product_id { get; set; }
        public string Source { get; set; }
        public int Photo_id { get; set; }
        public string Name { get; set; }
        public double Price  { get; set; }
        public double Discount { get; set; }


    }
}