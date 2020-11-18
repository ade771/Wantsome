using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Data.Models;
namespace MyShop.Data.Services
{
    public class SqlClothingShopProductPhoto : IClothingData<ProductPhoto>
    {
        public readonly ShopDbContext db;
        public SqlClothingShopProductPhoto(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(ProductPhoto productPhoto)
        {
            db.ProductPhotos.Add(productPhoto);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var productPhoto = db.ProductPhotos.Find(id);
            db.ProductPhotos.Remove(productPhoto);
            db.SaveChanges();
        }

        public  ProductPhoto Get(int id)
        {
            return db.ProductPhotos.FirstOrDefault(s => s.Photo_id == id);
        }

        public  IEnumerable<ProductPhoto> GetAll()
        {
            return db.ProductPhotos;
        }

        public  void Update(ProductPhoto productPhoto)
        {
            var entry = db.Entry(productPhoto);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

