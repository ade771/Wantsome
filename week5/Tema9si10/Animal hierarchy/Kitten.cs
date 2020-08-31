using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_hierarchy
{
    class Kitten : Cat
    {
        public Kitten(int age,string name,string sex) : base(age,name,sex)
        {
            this.Age = age;

            this.Sex = "female";
        }

    }
}
