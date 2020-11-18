using System.ComponentModel.DataAnnotations;

namespace MyShop.Data.Models
{
    public class Price
    {
        [Key]
        public int Price_id { get; set; }
        public double Net_price { get; set; }
        public double Discount { get; set; }

        [Required]
        public bool Active { get; set; }
        public int Product_id { get; set; }

        public Product Product { get; set; }




    }
}