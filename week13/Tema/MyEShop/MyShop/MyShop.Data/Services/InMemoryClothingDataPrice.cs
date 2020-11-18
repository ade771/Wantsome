using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyShop.Data.Models
{
    public class InMemoryClothingDataPrice : IClothingData<Price>
    {

        public List<Price> prices;

        public InMemoryClothingDataPrice()
        {


            prices = new List<Price> {
                    new Price { Price_id = 1, Product_id = 1, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 2, Product_id = 2, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 3, Product_id = 3, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 4, Product_id = 4, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 5, Product_id = 5, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 6, Product_id = 6, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 7, Product_id = 7, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 8, Product_id = 8, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 9, Product_id = 9, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 10, Product_id = 10, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 11, Product_id = 11, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 12, Product_id = 12, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 13, Product_id = 13, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 14, Product_id = 14, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 15, Product_id = 15, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 16, Product_id = 16, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 17, Product_id = 17, Net_price = 20, Discount = 0, Active = true },
                    new Price { Price_id = 18, Product_id = 18, Net_price = 25, Discount = 5, Active = true },
                    new Price { Price_id = 19, Product_id = 19, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 20, Product_id = 20, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 21, Product_id = 21, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 22, Product_id = 22, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 23, Product_id = 23, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 24, Product_id = 24, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 25, Product_id = 25, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 26, Product_id = 26, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 27, Product_id = 27, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 28, Product_id = 28, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 29, Product_id = 29, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 30, Product_id = 30, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 31, Product_id = 31, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 32, Product_id = 32, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 33, Product_id = 33, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 34, Product_id = 34, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 35, Product_id = 35, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 36, Product_id = 36, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 37, Product_id = 37, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 38, Product_id = 38, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 39, Product_id = 39, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 40, Product_id = 40, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 41, Product_id = 41, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 42, Product_id = 42, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 43, Product_id = 43, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 44, Product_id = 44, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 45, Product_id = 45, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 46, Product_id = 46, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 47, Product_id = 47, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 48, Product_id = 48, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 49, Product_id = 49, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 50, Product_id = 50, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 51, Product_id = 51, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 52, Product_id = 52, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 53, Product_id = 53, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 54, Product_id = 54, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 55, Product_id = 55, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 56, Product_id = 56, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 57, Product_id = 57, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 58, Product_id = 58, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 59, Product_id = 59, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 60, Product_id = 60, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 61, Product_id = 61, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 62, Product_id = 62, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 63, Product_id = 63, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 64, Product_id = 64, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 65, Product_id = 65, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 66, Product_id = 66, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 67, Product_id = 67, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 68, Product_id = 68, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 69, Product_id = 69, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 70, Product_id = 70, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 71, Product_id = 71, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 72, Product_id = 72, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 73, Product_id = 73, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 74, Product_id = 74, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 75, Product_id = 75, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 76, Product_id = 76, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 77, Product_id = 77, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 78, Product_id = 78, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 79, Product_id = 79, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 80, Product_id = 80, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 81, Product_id = 81, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 82, Product_id = 82, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 83, Product_id = 83, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 84, Product_id = 84, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 85, Product_id = 85, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 86, Product_id = 86, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 87, Product_id = 87, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 88, Product_id = 88, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 89, Product_id = 89, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 90, Product_id = 90, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 91, Product_id = 91, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 92, Product_id = 92, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 93, Product_id = 93, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 94, Product_id = 94, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 95, Product_id = 95, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 96, Product_id = 96, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 97, Product_id = 97, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 98, Product_id = 98, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 99, Product_id = 99, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 100, Product_id = 100, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 101, Product_id = 101, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 102, Product_id = 102, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 103, Product_id = 103, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 104, Product_id = 104, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 105, Product_id = 105, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 106, Product_id = 106, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 107, Product_id = 107, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 108, Product_id = 108, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 109, Product_id = 109, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 110, Product_id = 110, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 111, Product_id = 111, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 112, Product_id = 112, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 113, Product_id = 113, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 114, Product_id = 114, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 115, Product_id = 115, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 116, Product_id = 116, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 117, Product_id = 117, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 118, Product_id = 118, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 119, Product_id = 119, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 120, Product_id = 120, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 121, Product_id = 121, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 122, Product_id = 122, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 123, Product_id = 123, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 124, Product_id = 124, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 125, Product_id = 125, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 126, Product_id = 126, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 127, Product_id = 127, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 128, Product_id = 128, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 129, Product_id = 129, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 130, Product_id = 130, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 131, Product_id = 131, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 132, Product_id = 132, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 133, Product_id = 133, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 134, Product_id = 134, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 135, Product_id = 135, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 136, Product_id = 136, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 137, Product_id = 137, Net_price = 39, Discount = 0, Active = true },
                    new Price { Price_id = 138, Product_id = 138, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 139, Product_id = 139, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 140, Product_id = 140, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 141, Product_id = 141, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 142, Product_id = 142, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 143, Product_id = 143, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 144, Product_id = 144, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 145, Product_id = 145, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 146, Product_id = 146, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 147, Product_id = 147, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 148, Product_id = 148, Net_price = 10, Discount = 0, Active = true },
              
                };

        }

        public  void Add(Price price)
        {
            prices.Add(price);
            price.Price_id = prices.Max(r => r.Price_id) + 1;
        }

        public  void Delete(int id)
        {
            var price = Get(id);
            if (price != null)
            {
                prices.Remove(price);
            }
        }

        public  Price Get(int id)
        {
            return prices.FirstOrDefault(r => r.Price_id == id);
        }


        public  IEnumerable<Price> GetAll()
        {
            return prices;
        }
        public  void Update(Price price)
        {
            var existing = Get(price.Price_id);
            if (existing != null)
            {
                existing.Price_id = price.Price_id;

            }
        }
    }
}
