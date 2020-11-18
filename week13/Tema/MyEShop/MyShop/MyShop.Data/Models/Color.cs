using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyShop.Data.Models
{
    public class Color
    {
        [Key]
        public int Color_id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public IEnumerable<ProductVariant> ProductVariants { get; set; }

    }
}
