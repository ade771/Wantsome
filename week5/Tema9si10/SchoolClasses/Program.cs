using System;
using System.Collections.Generic;
namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.School classes

            // We are given a school. In the school there are classes of students.
            //Each class has a set of teachers.Each teacher teaches, a set of disciplines. 
            //Students have a name and unique class number. Classes have unique text identifier.
            //Teachers have a name.Disciplines have a name, number of lectures and number of exercises.

            //Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments
            //    (free text block).

            // Your task is to identify the classes(in terms of OOP) 
            //and their attributes and operations, encapsulate their fields, define the class hierarchy.

            Teacher teacher1 = new Teacher("Ionescu", new List<Disciplines>(){ new Disciplines("Math", 40, 100),
                                                                               new Disciplines("Chemistry",20,89)});


            Teacher teacher2 = new Teacher("Popescu", new List<Disciplines>(){ new Disciplines("Physics", 29, 120),
                                                                               new Disciplines("Biology",30,34)});

            Teacher teacher3 = new Teacher("Maricescu", new List<Disciplines>(){ new Disciplines("Geography", 19, 20),
                                                                               new Disciplines("History",21,23)});

            Teacher teacher4 = new Teacher("Niculescu", new List<Disciplines>(){ new Disciplines("English", 18, 45),
                                                                               new Disciplines("Francais",22,90)});


            Classes class1 = new Classes("ClassA", new List<Teacher>()
            { teacher1, teacher2 }, new List<Student>() { new Student("Alin", 1209),
                                                          new Student("Mihai", 1002),
                                                          new Student("Maria",1998),
                                                          new Student("Iona", 1888)
            });





            Classes class2 = new Classes("ClassB", new List<Teacher>()
            { teacher3, teacher4 }, new List<Student>() { new Student("Alesia", 1200),
                                                          new Student("Marcu", 1000),
                                                          new Student("Adelina",1995),
                                                          new Student("Iuliana", 1887)
            });
          
            Console.WriteLine(" This school has :  {0} and {1}", class1.ClassName, class2.ClassName);

            Console.WriteLine("Teachers from ClassA are:  {0} and {1}", teacher1.Name, teacher2.Name);
            Console.WriteLine($"Ionescu teaches : {teacher1.Disciplines[0].Name} and {teacher1.Disciplines[1].Name}");
            Console.WriteLine($"Popescu teaches : {teacher2.Disciplines[0].Name} and {teacher2.Disciplines[1].Name} ");
            Console.WriteLine($"The students from ClassA are : {class1.Students[0].Name}, {class1.Students[1].Name}, {class1.Students[2].Name}, {class1.Students[3].Name}");

           
            Console.WriteLine("Teachers from ClassB are:  {0} and {1}", teacher3.Name, teacher4.Name);
            Console.WriteLine($"Maricescu teaches : {teacher3.Disciplines[0].Name} and {teacher3.Disciplines[1].Name}");
            Console.WriteLine($"Niculescu teaches : {teacher4.Disciplines[0].Name} and {teacher4.Disciplines[1].Name} ");
            Console.WriteLine($"Students from ClassB are : {class2.Students[0].Name}, {class2.Students[1].Name}, {class2.Students[2].Name}, {class2.Students[3].Name}");
        }
    }
}
