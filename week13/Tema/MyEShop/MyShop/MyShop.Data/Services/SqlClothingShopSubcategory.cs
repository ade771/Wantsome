using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Data.Services
{
    public class SqlClothingShopSubcategory : IClothingData<Subcategory>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopSubcategory(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(Subcategory subcategory)
        {
            db.Subcategories.Add(subcategory);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var subcategory = db.Subcategories.Find(id);
            db.Subcategories.Remove(subcategory);
            db.SaveChanges();
        }
        public  Subcategory Get(int id)
        {
            return db.Subcategories.FirstOrDefault(s => s.Subcategory_id == id);
        }

        public  IEnumerable<Subcategory> GetAll()
        {
            return db.Subcategories.OrderBy(s => s.Name);
        }

        public  void Update(Subcategory subcategory)
        {
            var entry = db.Entry(subcategory);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
