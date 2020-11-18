using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class ProductPhoto
    {
        [Key]
        public int Photo_id { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string Alt { get; set; }
        public int Product_id { get; set; }

        public Product Product { get; set; }
    }
}