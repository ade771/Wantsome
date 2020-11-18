using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
   public class Product
    {
        [Key]
        public int Product_id { get; set; }

   
        [Required]
        public string Name { get; set; }

       [MaxLength(300)]     
       [Required]
        public string Description { get; set; }

        public int Category_id { get; set; }
        public int Subcategory_id { get; set; }
        public int? Type_id { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
        public ProductType ProductType { get; set; }
        public IEnumerable<Price> Prices { get; set; }
        public IEnumerable<ProductVariant> ProductVariants { get; set; }
        public IEnumerable<ProductPhoto> ProductPhotos { get; set; }
    }
}

