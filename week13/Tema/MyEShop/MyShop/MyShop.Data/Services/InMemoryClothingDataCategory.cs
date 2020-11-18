using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Models
{
    public class InMemoryClothingDataCategory : IClothingData<Category>
    {

        public List<Category> categories;
      
        public InMemoryClothingDataCategory()
        {
      
            categories = new List<Category> {
                    new Category { Category_id = 1, Name = "Men" },
                    new Category { Category_id = 2, Name = "Women" },
                    new Category { Category_id = 3, Name = "Kids"}
            };
           
        }

        public  void Add(Category category)
        {
            categories.Add(category);
            category.Category_id= categories.Max(r => r.Category_id) + 1;
        }

        public  void Delete(int id)
        {
            var category = Get(id);
            if (category != null)
            {
                categories.Remove(category);
            }
        }

        public  Category Get(int id)
        {
            return categories.FirstOrDefault(r => r.Category_id == id);
        }


        public  IEnumerable<Category> GetAll()
        {
            return categories.OrderBy(r => r.Category_id);
        }

        public  void Update(Category category)
        {
            var existing = Get(category.Category_id);
            if (existing != null)
            {
                existing.Name = category.Name;
               
            }
        }
    }
}
