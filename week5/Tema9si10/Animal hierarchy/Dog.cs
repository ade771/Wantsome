using System;
using System.Linq;

namespace Animal_hierarchy
{
    class Dog : Animals
    {
       
        public Dog(int age, string name, string sex) : base(age, name, sex)
        {



        }

        public override void Sound()
        {
            Console.WriteLine("Woof-Woof!");
        }

        
    }
}
