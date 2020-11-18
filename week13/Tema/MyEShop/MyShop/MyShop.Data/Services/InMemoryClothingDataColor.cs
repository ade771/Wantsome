using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyShop.Data.Models
{
    public class InMemoryClothingDataColor :IClothingData<Color>
    {
   
        public List<Color> colors;
    
        
        public InMemoryClothingDataColor()
        {


           colors = new List<Color> {
                    new Color { Color_id = 1, Name = "Red" },
                    new Color { Color_id = 2, Name = "Blue" },
                    new Color { Color_id = 3, Name = "Green" },
                    new Color { Color_id = 4, Name = "Yellow" },
                    new Color { Color_id = 5, Name = "Purple" },
                    new Color { Color_id = 6, Name = "Black" },
                    new Color { Color_id = 7, Name = "White" },
                    new Color { Color_id = 8, Name = "Brown"},                  
                    new Color {Color_id = 9, Name = "Grey"},
                    new Color{Color_id = 10, Name = "Multicolored"},
                    new Color {Color_id = 11, Name = "Pink"}
            };
         
        }

        public  void Add(Color color)
        {
            colors.Add(color);
            color.Color_id = colors.Max(r => r.Color_id) + 1;
        }

        public  void Delete(int id)
        {
            var color = Get(id);
            if (color != null)
            {
                colors.Remove(color);
            }
        }

        public  Color Get(int id)
        {
            return colors.FirstOrDefault(r => r.Color_id == id);
        }


        public  IEnumerable<Color> GetAll()
        {
            return colors.OrderBy(c => c.Name);
        }

        public  void Update(Color color)
        {
            var existing = Get(color.Color_id);
            if (existing != null)
            {
                existing.Name = color.Name;

            }
        }
    }
}
