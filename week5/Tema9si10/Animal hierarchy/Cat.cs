using System;



namespace Animal_hierarchy
{
    class Cat : Animals
    {

        public Cat(int age, string name, string sex) : base(age, name, sex)
        {

           

        }
        public override void Sound()
        {
            Console.WriteLine("Meowww!");
        } 

       
    }
}
