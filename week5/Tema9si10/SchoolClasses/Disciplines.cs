using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    class Disciplines
    {
        public string Name { get; set; }
        public int NumberOfLecture { get; set; }
        public int NumberOfExercices { get; set; }

        public Disciplines(string name, int numberOflecture, int numberOfexercices)
        {
            this.Name = name;
            this.NumberOfLecture = numberOflecture;
            this.NumberOfExercices = numberOfexercices;
        }
    }
}
