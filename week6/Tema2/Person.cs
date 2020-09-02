using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Person
    {

        private string name;
        private Nullable<int> age;

        public string Name { get; set; }
        public Nullable<int > Age { get; set; }

        public Person(string name, Nullable<int> age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

           
            if (this.name == null)
            {
                s.Append("Name: null");

            }
            else
            {
                s.AppendLine($"Name: { this.name}");
            }
            
            if (this.age == null)
            {
                s.Append("Age: null");
            }
            else
            {
                s.Append($"Age: {this.age}");
            }

            return s.ToString();

        }
    }
}