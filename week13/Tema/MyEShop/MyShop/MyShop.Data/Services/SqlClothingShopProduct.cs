using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Data.Services
{
    public class SqlClothingShopProduct : IClothingData<Product>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopProduct(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }
        public  Product Get(int id)
        {
            return db.Products.FirstOrDefault(s => s.Product_id == id);
        }

        public  IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public  void Update(Product product)
        {
            var entry = db.Entry(product);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

