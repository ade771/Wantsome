using System;
using System.Linq;
namespace Animal_hierarchy
{
    class Program
    {

        static void Main(string[] args)
        {
        //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
            // Dogs, frogs and cats are Animals.

            // All animals can produce sound(specified by the ISound interface).
            //Kittens and tomcats are cats.All animals are described by age, name and sex.

            //Kittens can be only female and tomcats can be only male.Each animal produces a specific sound.
            //Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method
            //(you may use LINQ).

            Cat[] cats = new Cat[]
             {
                new Cat(1,"Kitty","Female"),
                new Cat (2,"Bubu", "Male")
             };

            Dog[] dogs = new Dog[]
             {
                new Dog(3,"Loly","Female"),
                new Dog (4,"Silky", "Male")
             };

            Frog[] frogs = new Frog[]
             {
                new Frog(5,"Beauty","Female"),
                new Frog(5,"Beauty","Female"),
                new Frog (6,"Cenna", "Male")
             };
            Console.WriteLine($"{cats[0].Name} is a {cats[0].Sex} and has {cats[0].Age} years");
            Console.WriteLine($"{cats[1].Name} is a {cats[1].Sex} and has {cats[1].Age} years");
            Console.WriteLine($"{cats[0].Name} and {cats[1].Name} has the average of age:  " + Cat.CalculateAverage(cats));

            Console.WriteLine($"{dogs[0].Name} is a {dogs[0].Sex} and has {dogs[0].Age} years");
            Console.WriteLine($"{dogs[1].Name} is a {dogs[1].Sex} and has {dogs[1].Age} years");
            Console.WriteLine($"{dogs[0].Name} and {dogs[1].Name} has the average of age:  " + Dog.CalculateAverage(dogs));

            Console.WriteLine($"{frogs[0].Name} is a {frogs[0].Sex} and has {frogs[0].Age} years");
            Console.WriteLine($"{frogs[1].Name} is a {frogs[1].Sex} and has {frogs[1].Age} years");
            Console.WriteLine($"{frogs[0].Name} and {frogs[1].Name} has the average of age:  " + Frog.CalculateAverage(frogs));

        }







    }
}
