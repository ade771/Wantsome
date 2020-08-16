
namespace Tema_Pizza_
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PizzaTopping topping1 = new PizzaTopping(PizzaToppingtype.Vegetable, "Ciuperci", 0.9);
            PizzaBase pizzaBase = new PizzaBase(PizzaBasetype.Italian, "PizzaBase", 10.8) ;
            Pizza pizza = new Pizza(pizzaBase, "Pizza 1");
            pizza.AddTopping(topping1);
            pizza.Print();

            PizzaTopping topping2= new PizzaTopping(PizzaToppingtype.Cheese, "Mozzarella", 1);
            PizzaBase pizzaBase2 = new PizzaBase(PizzaBasetype.Regular, "PizzaBase", 12.8);
            Pizza pizza2 = new Pizza(pizzaBase, "Pizza 2");
            pizza2.AddTopping(topping2);
            pizza2.Print();
           
            PizzaTopping topping3 = new PizzaTopping(PizzaToppingtype.Meat, "Salami", 6.9);
            PizzaBase pizzaBase3 = new PizzaBase(PizzaBasetype.Thick, "PizzaBase", 13);
            Pizza pizza3 = new Pizza(pizzaBase, "Pizza 3");
            pizza3.AddTopping(topping3);
            pizza3.Print();
           
        }
    }
}
