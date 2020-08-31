using System;
using System.Linq;

namespace Animal_hierarchy
{
    class Frog : Animals
    {
        public Frog(int age, string name, string sex) : base(age, name, sex)
        {


        }

        public override void Sound()
        {
            Console.WriteLine("Croak!");
        }

      
           
    }
}
