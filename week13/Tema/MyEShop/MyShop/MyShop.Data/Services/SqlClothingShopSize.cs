using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class SqlClothingShopSize : IClothingData<Size>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopSize(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(Size size)
        {
            db.Sizes.Add(size);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var size = db.Sizes.Find(id);
            db.Sizes.Remove(size);
            db.SaveChanges();
        }

        public  Size Get(int id)
        {
            return db.Sizes.FirstOrDefault(s => s.Size_id == id);
        }

        public  IEnumerable<Size> GetAll()
        {
            return db.Sizes.OrderBy(s => s.Name);
        }

        public  void Update(Size size)
        {
            var entry = db.Entry(size);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
