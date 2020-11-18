using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Data.Models
{
   public interface  IClothingData<T>
    {     
      IEnumerable<T> GetAll();
       void Add(T parameterName);
        T Get(int id);
       void Update(T parameterName);
        void Delete(int id);
    }
}
