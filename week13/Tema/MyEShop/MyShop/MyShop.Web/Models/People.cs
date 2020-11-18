using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class People
    {
        public int Product_id { get; set; }
        public string Source { get; set; }
        public int Photo_id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Category_id { get; set; }
        public int Subcategory_id { get; set; }
        public string SubcategoryName { get; set; }
    }
}