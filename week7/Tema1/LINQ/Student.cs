using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Student
    {
        

        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public Student(int studentId, String studentName,int age)
        {
            this.StudentID = studentId;
            this.StudentName = studentName;
            this.Age = age;
        }
    }
}
