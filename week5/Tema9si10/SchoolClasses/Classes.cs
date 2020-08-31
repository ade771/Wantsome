using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    class Classes
    {
        public string ClassName { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Classes(string className, List<Teacher> teachers, List<Student> students)
        {
            this.ClassName = className;
            this.Teachers = teachers;
            this.Students = students;

        }

                                      
       
    }
}
