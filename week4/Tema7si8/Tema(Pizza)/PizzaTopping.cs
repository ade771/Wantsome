using System;

namespace Tema_Pizza_
{
        public class PizzaTopping
        {

            public string Name { get; set; }

            public double Cost { get; set; }

            public PizzaToppingtype Type { get; set; }

            public PizzaTopping(PizzaToppingtype type, string name, double cost)
            {
                this.Type = type;
                this.Name = name;
                this.Cost = cost;
            }

           

            public void Print()
            {
                if (this.Type == PizzaToppingtype.Meat)
                {
                    Console.WriteLine($"Name: {this.Name.ToUpper()}");
                }
                else
                {
                    Console.WriteLine($" Name: {this.Name}");
                }

            }
        }

        public enum PizzaToppingtype
        {
            Cheese, Meat, Vegetable
        }
    }
    
