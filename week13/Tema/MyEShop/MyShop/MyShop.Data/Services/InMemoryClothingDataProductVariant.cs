using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataProductVariant : IClothingData<ProductVariant>
    {

        public List<ProductVariant> productVariants;


        public InMemoryClothingDataProductVariant()
        {


            productVariants = new List<ProductVariant>{

                    new ProductVariant { ProductVariant_Id = 1, Product_id = 1, Color_id = 8,  Quantity = 12 },
                    new ProductVariant { ProductVariant_Id = 2, Product_id = 2, Color_id =8,  Quantity = 12 },
                    new ProductVariant { ProductVariant_Id = 3, Product_id = 3, Color_id = 9,  Quantity = 12 },
                    new ProductVariant { ProductVariant_Id = 4, Product_id = 4, Color_id = 6,Size_id = 1,Quantity = 5 },
                    new ProductVariant { ProductVariant_Id = 5, Product_id = 5, Color_id = 2,Size_id = 2,Quantity = 10},
                    new ProductVariant { ProductVariant_Id = 6, Product_id = 6, Color_id  = 8,Size_id = 1,Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 7, Product_id = 6, Color_id = 6, Size_id = 2,Quantity = 7},
                    new ProductVariant { ProductVariant_Id = 8, Product_id = 7, Color_id = 7,Size_id = 3,Quantity = 3},
                    new ProductVariant { ProductVariant_Id = 9, Product_id = 7,Color_id = 9,Size_id = 4,Quantity = 4 },
                    new ProductVariant { ProductVariant_Id = 10, Product_id = 7, Color_id = 8,Size_id = 1, Quantity = 5},
                    new ProductVariant { ProductVariant_Id = 11, Product_id = 8, Color_id = 10,Size_id = 2, Quantity = 11},
                    new ProductVariant { ProductVariant_Id = 12, Product_id = 9, Color_id = 10,Size_id = 3,Quantity = 11},
                    new ProductVariant { ProductVariant_Id = 13, Product_id = 10, Color_id= 7,Quantity = 3},
                    new ProductVariant { ProductVariant_Id = 14, Product_id = 10,Color_id= 4, Quantity = 12 },
                    new ProductVariant { ProductVariant_Id = 15, Product_id = 10, Color_id = 6, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 16, Product_id = 11, Color_id = 10, Quantity = 2},
                    new ProductVariant { ProductVariant_Id = 17, Product_id = 12,Color_id = 2, Quantity =4 },
                    new ProductVariant { ProductVariant_Id = 18, Product_id = 13,Color_id = 2,Quantity =4 },
                    new ProductVariant { ProductVariant_Id = 19, Product_id = 14,Color_id = 4,Size_id = 2, Quantity = 10},
                    new ProductVariant { ProductVariant_Id = 20, Product_id = 15, Color_id = 6, Size_id = 3, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 21, Product_id = 16, Color_id = 9, Size_id = 4, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 22, Product_id = 17,Color_id = 6, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 23, Product_id = 17,Color_id = 7, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 24, Product_id = 18,Color_id = 10, Size_id = 5, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 25, Product_id = 19,Color_id = 2, Size_id = 3, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 26, Product_id = 20,Color_id = 8, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 27, Product_id = 21,Color_id = 2, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 28, Product_id = 21,Color_id = 6, Size_id = 6, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 29, Product_id = 22,Color_id = 3, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 30, Product_id = 22,Color_id = 2, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 31, Product_id = 23,Color_id = 11, Size_id = 3, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 32, Product_id = 24, Color_id = 9, Size_id = 3, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 33, Product_id = 25, Color_id = 11, Size_id = 3, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 34, Product_id = 25, Color_id = 1, Size_id = 4, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 35, Product_id = 25, Color_id = 7, Size_id = 1, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 36, Product_id = 26, Color_id = 10, Size_id = 1, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 37, Product_id = 27,Color_id = 10, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 38, Product_id = 28,Color_id = 11, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 39, Product_id = 29,Color_id = 9, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 40, Product_id = 30,Color_id = 10, Size_id = 3, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 41, Product_id = 31,Color_id = 6, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 42, Product_id = 32,Color_id = 1, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 43, Product_id = 33,Color_id = 7, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 44, Product_id = 34,Color_id = 7, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 45, Product_id = 35, Color_id = 10, Size_id = 3, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 46, Product_id = 36, Color_id = 11, Size_id = 1, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 47, Product_id = 37,Color_id = 11, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 48, Product_id = 38,Color_id = 6, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 49, Product_id = 39,Color_id = 7, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 50, Product_id = 39,Color_id = 4, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 51, Product_id = 40,Color_id = 8, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 52, Product_id = 41,Color_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 53, Product_id = 42, Color_id = 8,Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 54, Product_id = 43, Color_id = 9, Size_id = 4, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 55, Product_id = 44,Color_id = 8, Size_id = 4, Quantity = 8},
                    new ProductVariant { ProductVariant_Id = 56, Product_id = 45,Color_id = 1, Size_id = 4, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 57, Product_id = 46,Color_id = 6, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 58, Product_id = 47,Color_id = 7, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 59, Product_id = 48,Color_id = 11, Size_id = 2, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 60, Product_id = 49,Color_id = 2, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 61, Product_id = 50,Color_id = 6, Size_id = 3, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 62, Product_id = 51,Color_id = 11, Size_id = 1, Quantity = 8 },
                    new ProductVariant { ProductVariant_Id = 63, Product_id = 51,Color_id = 6, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 64, Product_id = 52,Color_id = 7, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 65, Product_id = 53,Color_id = 10, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 66, Product_id = 54,Color_id = 7, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 67, Product_id = 55,Color_id = 10, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 68, Product_id = 56,Color_id = 11, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 69, Product_id = 57,Color_id = 5,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 70, Product_id = 58,Color_id = 10,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 71, Product_id = 59,Color_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 72, Product_id = 60,Color_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 73, Product_id = 61,Color_id = 11, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 74, Product_id = 62,Color_id = 10,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 75, Product_id = 63,Color_id = 6, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 76, Product_id = 64,Color_id = 4,Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 77, Product_id = 65,Color_id = 10, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 78, Product_id = 66,Color_id = 11, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 79, Product_id = 67, Color_id = 3,  Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 80, Product_id = 68,Color_id = 6, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 81, Product_id = 69,Color_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 82, Product_id = 70,Color_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 83, Product_id = 71, Color_id = 4, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 84, Product_id = 72,Color_id = 7, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 85, Product_id = 73, Color_id = 6, Size_id = 3, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 86, Product_id = 74,Color_id = 4, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 87, Product_id = 75, Color_id = 1, Size_id = 3, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 88, Product_id = 76,Color_id = 9, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 89, Product_id = 77,Color_id = 9, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 90, Product_id = 78,Color_id = 9, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 91, Product_id = 79,Color_id = 6, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 92, Product_id = 80, Color_id = 10, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 93, Product_id = 81,Color_id = 10, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 94, Product_id = 82,Color_id = 4, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 95, Product_id = 83,Color_id = 6, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 96, Product_id = 84,Color_id = 2, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 97, Product_id = 85,Color_id = 6, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 98, Product_id = 86, Color_id = 3, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 99, Product_id = 87,Color_id = 2, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 100, Product_id = 88,Color_id = 1, Size_id = 4, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 101, Product_id = 89,Color_id = 2, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 102, Product_id = 90,Color_id = 2, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 103, Product_id = 91,Color_id = 2, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 104, Product_id = 92,Color_id = 2, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 105, Product_id = 93,Color_id = 2, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 106, Product_id = 94, Color_id = 2, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 107, Product_id = 95,Color_id = 9, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 108, Product_id = 96,Color_id = 9, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 109, Product_id = 97,Color_id = 3, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 110, Product_id = 98,Color_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 111, Product_id = 99,Color_id = 9,  Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 112, Product_id = 100,Color_id = 2,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 113, Product_id = 101, Color_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 114, Product_id = 102, Color_id = 10, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 115, Product_id = 103,Color_id = 7, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 116, Product_id = 104,Color_id = 3, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 117, Product_id = 105,Color_id = 6, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 118, Product_id = 106,Color_id = 2, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 119, Product_id = 107, Color_id = 4, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 120, Product_id = 108,Color_id = 2,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 121, Product_id = 109,Color_id = 2,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 122, Product_id = 110, Color_id = 11,  Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 123, Product_id = 111,Color_id = 1,  Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 124, Product_id = 112,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 125, Product_id = 113,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 126, Product_id = 114,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 127, Product_id = 115, Color_id = 11, Size_id = 3, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 128, Product_id = 116,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 129, Product_id = 117, Color_id = 11, Size_id = 3, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 130, Product_id = 118, Color_id = 11, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 131, Product_id = 119,Color_id = 10, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 132, Product_id = 120,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 133, Product_id = 121, Color_id = 11, Size_id = 3, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 134, Product_id = 122, Color_id = 11, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 135, Product_id = 123, Color_id = 2, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 136, Product_id = 124,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 137, Product_id = 125, Color_id = 10, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 138, Product_id = 126, Color_id = 11, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 139, Product_id = 127,Color_id = 4, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 140, Product_id = 128, Color_id = 9, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 141, Product_id = 129,Color_id = 10, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 142, Product_id = 130,Color_id = 10, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 143, Product_id = 131, Color_id = 2, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 144, Product_id = 132, Color_id = 2, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 145, Product_id = 133,Color_id = 11, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 146, Product_id = 134,Color_id = 2, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 147, Product_id = 135, Color_id = 2, Size_id = 4, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 148, Product_id = 136,Color_id = 2, Size_id = 4, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 149, Product_id = 137, Color_id = 2, Size_id = 2, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 150, Product_id = 138, Color_id = 6, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 151, Product_id = 139,Color_id = 11, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 152, Product_id = 140,Color_id = 11, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 153, Product_id = 141, Color_id = 7, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 154, Product_id = 142,Color_id = 11, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 155, Product_id = 143,Color_id = 9, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 156, Product_id = 144,Color_id = 11, Size_id = 3, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 157, Product_id = 145, Color_id = 11, Size_id = 1, Quantity = 8},
                   new ProductVariant { ProductVariant_Id = 158, Product_id = 146,Color_id = 11, Size_id = 2, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 159, Product_id = 147,Color_id = 10, Size_id = 1, Quantity = 8 },
                   new ProductVariant { ProductVariant_Id = 160, Product_id = 148,Color_id = 2, Size_id = 1, Quantity = 8 }
            };
        }


        public  void Add(ProductVariant productVariant)
        {
            productVariants.Add(productVariant);
            productVariant.ProductVariant_Id = productVariants.Max(r => r.ProductVariant_Id) + 1;
        }

        public  void Delete(int id)
        {
            var productVariant = Get(id);
            if (productVariant != null)
            {
                productVariants.Remove(productVariant);
            }
        }

        public  ProductVariant Get(int id)
        {
            return productVariants.FirstOrDefault(r => r.ProductVariant_Id == id);
        }


        public  IEnumerable<ProductVariant> GetAll()
        {
            return productVariants.OrderBy(r => r.ProductVariant_Id);
        }

        public  void Update(ProductVariant productVariant)
        {
            var existing = Get(productVariant.ProductVariant_Id);
            if (existing != null)
            {
                existing.ProductVariant_Id = productVariant.ProductVariant_Id;

            }
        }
    }
}