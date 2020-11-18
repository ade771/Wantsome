using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataSize : IClothingData<Size>
    {

        public List<Size> sizes;

        public InMemoryClothingDataSize()
        {
            sizes = new List<Size> {
                    new Size { Size_id = 1, Name = "XS" },
                    new Size { Size_id = 2, Name = "S" },
                    new Size { Size_id = 3, Name = "M" },
                    new Size { Size_id = 4, Name = "XL" },
                    new Size { Size_id = 5, Name = "L" },
                    new Size { Size_id = 6, Name = "XXL" }
            };



        }

        public  void Add(Size size)
        {
            sizes.Add(size);
            size.Size_id = sizes.Max(r => r.Size_id) + 1;
        }

        public  void Delete(int id)
        {
            var size = Get(id);
            if (size != null)
            {
                sizes.Remove(size);
            }
        }

        public  Size Get(int id)
        {
            return sizes.FirstOrDefault(r => r.Size_id == id);
        }


        public  IEnumerable<Size> GetAll()
        {
            return sizes.OrderBy(r => r.Name);
        }

        public  void Update(Size size)
        {
            var existing = Get(size.Size_id);
            if (existing != null)
            {
                existing.Name = size.Name;

            }
        }
    }
}