using System;
using System.Collections.Generic;
using static Tema_Pizza_.Program;

namespace Tema_Pizza_
{
    public class Pizza
    {
   

        public string Name { get; set; }
        public PizzaBase PizzaB { get; set; }
        public List<PizzaTopping> Topping { get; set; }
        public double Cost { get; private set; }

        public Pizza(PizzaBase pizzaBase, string name)
        {
            this.PizzaB = pizzaBase;
            this.Name = name;
            this.Topping = new List<PizzaTopping>();
        }



        public void AddTopping(PizzaTopping topping)
        {
            this.Topping.Add(topping);
        }



        public double CalculateTotalCost()

        {
            double sum = 0;
            sum = sum + this.PizzaB.Cost;
            foreach (var pizzaTopping in Topping)
            {
                sum = sum + pizzaTopping.Cost;
            }

            return sum;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza: {this.Name}");
            this.PizzaB.Print();
            foreach (var topping in Topping)
            {
                topping.Print();
            }

            Console.WriteLine($"The cost is: {this.CalculateTotalCost()}");

        }
    }


}
