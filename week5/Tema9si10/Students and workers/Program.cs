using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_and_workers
{
    class Program
    {
        static void OrderByGrade(List<Student> students)
        {
            var orderByGrade = from s in students
                               orderby s.Grade ascending
                               select s;
            Console.WriteLine("Students:");
            foreach (var st in orderByGrade)
            {
                Console.WriteLine($"Student : {st.FirstName} {st.LastName}, {st.Grade}");
            }
        }
        static void OrderByMoneyPerHour(List<Worker> workers)
        
        {
              var orderByMoney = from w in workers
                                 orderby w.MoneyPerHour() descending
                                  select w;
            Console.WriteLine("Workers:");
            foreach (var st in orderByMoney)
            {
                Console.WriteLine($"Worker : {st.FirstName} {st.LastName}, {st.MoneyPerHour()}");
            }


        }

        
        static void Main(string[] args)
        {
            //  Define abstract class Human with a first name and a last name.
            //  Define a new class Student which is derived from Human and has a new field – grade.
            //  Define class Worker derived from Human with a new property WeekSalary 
            //   and WorkHoursPerDay and a method MoneyPerHour() that returns money
            //   earned per hour by the worker.Define the proper constructors and properties for this hierarchy.

            //  Tasks:

            //Initialize a list of 10 students and sort them by grade in ascending order
            //(use LINQ or OrderBy() extension method).
            //Initialize a list of 10 workers and sort them by money per hour in descending or
            //Merge the lists and sort them by first name and last name.


            List<Student> students = new List<Student>()
            {
                new Student("Mircu", "Alin", 10),
                new Student("Ionescu", "Marcu", 5),
                new Student("Popescu", "Ana", 7),
                new Student("Niculescu", "Vlad", 8),
                new Student("Arsines", "Victor", 9),
                new Student("Mars", "John", 2),
                new Student("Bill", "Gates", 6),
                new Student("Lond", "Adelina", 4),
                new Student("Gabrilescu", "Victoria", 1),
                new Student("Sorescu", "Antonia", 3)
            };

            
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Mircu", "Alin" , 1000, 8),
                new Worker("Ionescu", "Marcu", 1000, 8),
                new Worker("Popescu", "Ana", 700,8),
                new Worker("Niculescu", "Vlad", 2999,9),
                new Worker("Arsines", "Victor",9000,12),
                new Worker("Mars", "John",1200,8),
                new Worker("Bill", "Gates", 6000,10),
                new Worker("Lond", "Adelina", 4000,10),
                new Worker("Gabrilescu", "Victoria",1100,8),
                new Worker("Sorescu", "Antonia", 3000,6)
            };

            OrderByGrade(students);
            OrderByMoneyPerHour(workers);




        }
     
    }
}
