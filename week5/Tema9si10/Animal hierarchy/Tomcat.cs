using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_hierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex) : base(age, name, sex)
        {

            this.Age = age;
            this.Sex = "male";
        }
    }
}
