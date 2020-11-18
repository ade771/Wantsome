using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class Category
    {
        [Key]
        public int Category_id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
      public IEnumerable<Product> Products { get; set; }
    }
}