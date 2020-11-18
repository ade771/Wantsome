using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
   public class SqlClothingShopCategory: IClothingData<Category>
    {

        private readonly ShopDbContext db;
        public SqlClothingShopCategory(ShopDbContext db)
        {
            this.db = db;
        }
       

        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public  Category Get(int id)
        {
            return db.Categories.FirstOrDefault(s => s.Category_id == id);
        }

        public  IEnumerable<Category> GetAll()
        {
            return db.Categories.OrderBy(s => s.Name);
        }

        public  void Update(Category category)
        {
            var entry = db.Entry(category);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
