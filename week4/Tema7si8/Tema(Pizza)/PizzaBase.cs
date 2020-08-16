using System;

namespace Tema_Pizza_
{
    public class PizzaBase
    {

        public PizzaBasetype Type { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
       
        public PizzaBase(PizzaBasetype type, string name, double cost)
        {
            this.Type = type;
            this.Name = name;
            if (this.Type == PizzaBasetype.Italian)
                this.Cost = cost * 1.5;
            else
                this.Cost = cost;
        }

        public void Print()
        {

            Console.WriteLine(this.Name);

        }

    }
    
        public enum PizzaBasetype
        {
            Regular, Thick, Italian


        }

 }


