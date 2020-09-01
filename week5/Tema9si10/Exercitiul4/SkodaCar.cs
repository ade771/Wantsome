using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercice
{
    class SkodaCar : IVehicle
    {


        public string ModelName { get; set; }
        public int BuildYear { get; set; }
        public IProducer Producer { get; set; }
        public double Price { get; set; }

        public SkodaCar(int year, double price)
        {
            this.BuildYear = year;
            this.Price = price;
            this.ModelName = "Skoda Octavia";
        }
    }
}