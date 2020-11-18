using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataProductType : IClothingData<ProductType>
    {

        public List<ProductType> productTypes;

        public InMemoryClothingDataProductType()
        {
            productTypes = new List<ProductType> {
                    new ProductType { Type_id = 1, Name = "Eyewear" },
                    new ProductType { Type_id = 2, Name = "Hats" },               
                    new ProductType { Type_id = 3, Name = "Jewellery" },
                    new ProductType { Type_id = 4, Name = "Mini" },
                    new ProductType { Type_id = 5, Name = "Large" },
                    new ProductType { Type_id = 6, Name = "Lace" },
                    new ProductType { Type_id = 7, Name = "Plain" },
                    new ProductType { Type_id = 8, Name = "Maxi" },
                    new ProductType { Type_id = 9, Name = "Midi" },
                    new ProductType { Type_id = 10, Name = "Flats" },
                    new ProductType { Type_id = 11, Name = "High-heels" },
                    new ProductType { Type_id = 12, Name = "Sneakers" },
                    new ProductType { Type_id = 13, Name = "Summer shoes" },
                    new ProductType { Type_id = 14, Name = "Basic" },
                    new ProductType { Type_id = 15, Name = "Sleeveless" },
                    new ProductType { Type_id = 16, Name = "Belts" },
                    new ProductType { Type_id = 17, Name = "Sunglasses" },
                    new ProductType { Type_id = 18, Name = "Checked" },
                    new ProductType { Type_id = 19, Name = "Vests" },
                    new ProductType { Type_id = 20, Name = "Bomber" },
                    new ProductType { Type_id = 21, Name = "Denim" },
                    new ProductType { Type_id = 22, Name = "Regular fit" },
                    new ProductType { Type_id = 23, Name = "Leather" },
                    new ProductType { Type_id = 24, Name = "Slim fit" },
                    new ProductType { Type_id = 25, Name = "Casual" },
                    new ProductType { Type_id = 26, Name = "Moccasins" },
                    new ProductType { Type_id = 27, Name = "Chinos" },
                    new ProductType { Type_id = 28, Name = "Tailored" },
                    new ProductType { Type_id = 29, Name = "Striped" },
                    new ProductType { Type_id = 30, Name = "Printed" },               
                    new ProductType {Type_id = 31, Name = "Caps"}
                };




        }

        public  void Add(ProductType productType)
        {
            productTypes.Add(productType);
            productType.Type_id = productTypes.Max(r => r.Type_id) + 1;
        }

        public  void Delete(int id)
        {
            var productType = Get(id);
            if (productType != null)
            {
                productTypes.Remove(productType);
            }
        }

        public  ProductType Get(int id)
        {
            return productTypes.FirstOrDefault(r => r.Type_id == id);
        }


        public  IEnumerable<ProductType> GetAll()
        {
            return productTypes.OrderBy(r => r.Name);
        }

        public  void Update(ProductType productType)
        {
            var existing = Get(productType.Type_id);
            if (existing != null)
            {
                existing.Name = productType.Name;

            }
        }
    }
}