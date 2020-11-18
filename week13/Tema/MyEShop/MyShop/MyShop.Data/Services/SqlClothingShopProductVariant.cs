using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Data.Models;

namespace MyShop.Data.Services
{
    public class SqlClothingShopProductVariant : IClothingData<ProductVariant>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopProductVariant(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(ProductVariant productVariant)
        {
            db.ProductVariants.Add(productVariant);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var productVariant = db.ProductVariants.Find(id);
            db.ProductVariants.Remove(productVariant);
            db.SaveChanges();
        }

        public  ProductVariant Get(int id)
        {
            return db.ProductVariants.FirstOrDefault(s => s.ProductVariant_Id == id);
        }

        public  IEnumerable<ProductVariant> GetAll()
        {
            return db.ProductVariants.OrderBy(s => s.Product_id);
        }

        public  void Update(ProductVariant productVariant)
        {
            var entry = db.Entry(productVariant);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
