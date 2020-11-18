using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Models
{
  public  class OrderDetail
    {
        [Key]
        public int OrderDetailId_id { get; set; }
        public int ProductPhoto_Id { get; set; }
        public int Order_Id { get; set; }
        public double Amount { get; set; }
        public double UnitPrice { get; set; }
        public ProductPhoto ProductPhoto { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
