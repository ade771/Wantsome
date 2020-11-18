using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShop.Data.Models
{
   public class ProductType
    {
        [Key]
        public int Type_id { get; set; }

        [MaxLength(55)]
        [Required]
        public string Name { get; set; }
       public IEnumerable<Product> Products { get; set; }
    }
}
