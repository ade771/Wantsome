using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    class Teacher : People
    {
        public List<Disciplines> Disciplines { get; set; }

        public Teacher(string name, List<Disciplines> disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }

       

    }
}
