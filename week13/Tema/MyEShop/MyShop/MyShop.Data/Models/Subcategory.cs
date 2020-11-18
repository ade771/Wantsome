using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class Subcategory
    {
        [Key]
        public int Subcategory_id { get; set; }

       [MaxLength(100)]
        [Required]
        public string Name { get; set; }
      public IEnumerable<Product> Products { get; set; }
    }
}