using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    class Student: People

    {
        public int ClassNumber { get; set; }

        public Student( string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

       
    }
}
