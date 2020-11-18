using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Data.Models;

namespace MyShop.Data.Services
{
  public  class SqlClothingShopPrice : IClothingData<Price>
    {
        private readonly ShopDbContext db;
        public SqlClothingShopPrice(ShopDbContext db)
        {
            this.db = db;
        }
        public  void Add(Price price)
        {
            db. Prices.Add(price);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            var price = db.Prices.Find(id);
            db.Prices.Remove(price);
            db.SaveChanges();
        }

        public  Price Get(int id)
        {
            return db.Prices.FirstOrDefault(s => s.Price_id == id);
        }

        public  IEnumerable<Price> GetAll()
        {
            return db.Prices.OrderBy(s => s.Net_price);
        }

        public  void Update(Price price)
        {
            var entry = db.Entry(price);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
