using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataSubcategory : IClothingData<Subcategory>
    {

        public List<Subcategory> subcategories;

        public InMemoryClothingDataSubcategory()
        {

            subcategories = new List<Subcategory> {
                    new Subcategory { Subcategory_id = 1, Name = "Accessories" },
                    new Subcategory { Subcategory_id = 2, Name = "Backpacks" },
                    new Subcategory { Subcategory_id = 3, Name = "Blazers" },
                    new Subcategory { Subcategory_id = 4, Name = "Jackets" },
                    new Subcategory { Subcategory_id = 5, Name = "Jeans" },
                    new Subcategory { Subcategory_id = 6, Name = "Shirts" },
                    new Subcategory { Subcategory_id = 7, Name = "Shoes" },
                    new Subcategory { Subcategory_id = 8, Name = "Trousers" },
                    new Subcategory { Subcategory_id = 9, Name = "T-Shirts" },
                    new Subcategory { Subcategory_id = 10, Name = "Underwear" },
                    new Subcategory { Subcategory_id = 11, Name = "Bags" },
                    new Subcategory { Subcategory_id = 12, Name = "Body" },
                    new Subcategory { Subcategory_id = 13, Name = "Dresses" },
                    new Subcategory { Subcategory_id = 14, Name = "Jumpsuits" },
                    new Subcategory { Subcategory_id = 15, Name = "Skirts" },
                    new Subcategory { Subcategory_id = 16, Name = "Swimwear" },
                    new Subcategory {Subcategory_id = 17, Name = "Shorts"}
                };


        }

        public  void Add(Subcategory subcategory)
        {
            subcategories.Add(subcategory);
            subcategory.Subcategory_id = subcategories.Max(r => r.Subcategory_id) + 1;
        }

        public  void Delete(int id)
        {
            var subcategory = Get(id);
            if (subcategory != null)
            {
                subcategories.Remove(subcategory);
            }
        }

        public  Subcategory Get(int id)
        {
            return subcategories.FirstOrDefault(r => r.Subcategory_id == id);
        }


        public  IEnumerable<Subcategory> GetAll()
        {
            return subcategories.OrderBy(r => r.Name);
        }

        public  void Update(Subcategory subcategory)
        {
            var existing = Get(subcategory.Subcategory_id);
            if (existing != null)
            {
                existing.Name = subcategory.Name;

            }
        }
    }
}
