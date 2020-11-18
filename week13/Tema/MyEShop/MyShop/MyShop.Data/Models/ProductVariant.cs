using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class ProductVariant
    {
        [Key]
        public int ProductVariant_Id { get; set; }
        public int Product_id { get; set; }
        public int? Size_id { get; set; }
        public int? Color_id { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}