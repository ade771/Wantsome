using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name + " ");

            Student[] studentarray = {
                new Student(1, "john", 18),
                new Student(2, "steve", 21),
                new Student(3, "bill", 2),
                new Student(4, "ram", 20),
                new Student(5, "ron", 31),
                new Student(6, "chris",17),
                new Student(7, "rob", 19),
            };

            Student[] students = new Student[10];

            int i = 0;

            foreach (Student std in studentarray)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    students[i] = std;
                    i++;
                    Console.WriteLine($"Student : {std.StudentName},{std.Age}");
                }
            }


            // Use Delegates to Find Elements from the Collection
            Student[] studentarray1 = {
                new Student(1, "john", 18),
                new Student(2, "steve", 21),
                new Student(3, "bill", 2),
                new Student(4, "ram", 20),
                new Student(5, "ron", 31),
                new Student(6, "chris",17),
                new Student(7, "rob", 19),
            };

            Student[] Students = StudentExtension.Where(studentarray1, delegate (Student std) {
                return std.Age > 12 && std.Age < 20;
            });
           // string collection
            IList<string> stringList = new List<string>() {
                        "c# tutorials",
                         "vb.net tutorials",
                         "learn c++",
                         "mvc tutorials" ,
                            "java"
                     };
            // linq query syntax
            var result = from s in stringList
                         where s.Contains("tutorials")
                         select s;
            foreach (var s in result)
            {
                Console.WriteLine(s + " ");
            }

            // Student collection
            IList<Student> studentList = new List<Student>() {
                    new Student(1, "John", 18),
                        new Student(2, "Steve", 21),
                        new Student(3, "Bill", 2),
                        new Student(4, "Ram", 20),
                        new Student(5, "Ron", 31),
                        new Student(6, "Chris",17),
                        new Student(7, "Rob", 19)
                     };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            foreach (var s in teenAgerStudent)
            {
                Console.WriteLine($"{s.StudentName} : {s.Age}");
            }


            // LINQ Method Syntax in C#
            // string collection
            IList<string> stringList1 = new List<string>() {
                        "C# Tutorials",
                        "VB.NET Tutorials",
                        "Learn C++",
                        "MVC Tutorials" ,
                        "Java"
            };

            // LINQ Query Syntax
            var result1 = stringList1.Where(s => s.Contains("Tutorials"));
            foreach (var s in result1)
            {
                Console.WriteLine(s + " ");
            }

            //Method Syntax
            var teenAgerStudents1 = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                  .ToList<Student>();

            foreach (var s in teenAgerStudents1)
            {
                Console.WriteLine(s.Age + " ");


            }
        }
    }
}
