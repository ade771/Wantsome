using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{

    public class SqlClothingShopColor : IClothingData<Color>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopColor(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(Color color)
        {
            db.Colors.Add(color);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var color = db.Colors.Find(id);
            db.Colors.Remove(color);
            db.SaveChanges();
        }


        public  Color Get(int id)
        {
            return db.Colors.FirstOrDefault(s => s.Color_id == id);
        }

        public  IEnumerable<Color> GetAll()
        {
            return db.Colors.OrderBy(s => s.Name);
        }

        public  void Update(Color color)
        {
            var entry = db.Entry(color);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
