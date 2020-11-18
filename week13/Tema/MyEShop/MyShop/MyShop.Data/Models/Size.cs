using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShop.Data.Models
{
   public class Size
    {
        [Key]
        public int Size_id { get; set; }

        [MaxLength(10)]
        [Required]
        public string Name { get; set; }

        public IEnumerable<ProductVariant> ProductVariants { get; set; }

    }
}
