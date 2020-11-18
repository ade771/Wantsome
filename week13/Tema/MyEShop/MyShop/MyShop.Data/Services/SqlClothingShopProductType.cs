using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Data.Models;
namespace MyShop.Data.Services
{
    public class SqlClothingShopProductType : IClothingData<ProductType>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopProductType(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(ProductType productType)
        {
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var productType = db.ProductTypes.Find(id);
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
        }

        public  ProductType Get(int id)
        {
            return db.ProductTypes.FirstOrDefault(s => s.Type_id == id);
        }

        public  IEnumerable<ProductType> GetAll()
        {
            return db.ProductTypes.OrderBy(s => s.Name);
        }

        public  void Update(ProductType productType)
        {
            var entry = db.Entry(productType);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}