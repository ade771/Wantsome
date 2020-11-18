using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class Cart
    {
     
        [Key]
        public int CartId { get; set; }
        public int Photo_id { get; set; }
        public int Quantity { get; set; }
        public ProductPhoto Photo { get; set; }     
        public System.DateTime DateCreated { get; set; }
    }
}