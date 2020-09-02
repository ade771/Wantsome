using System;

namespace Tema2
{
    class Program
    {
        //Problem 1.Student class
        //   Define a class Student, which contains data about a student – first, middle and last name,
        //    SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
        //    Use an enumeration for the specialties, universities and faculties.
        //    Override the standard methods, inherited by System.Object:
        //    Equals(), ToString(), GetHashCode() and operators ==and !=

        //Problem 2. ICloneable

        //Add implementations of the ICloneable interface.
        // The Clone() method should deeply copy all object's fields into a new object of type Student.
        //Problem 3. IComparable

        //Implement the IComparable<Student> interface to compare students by names(as first criteria, in lexicographic order) 
        //  and by social security number
        // (as second criteria, in increasing order).
        //Problem 4. Person class

        //Create a class Person with two fields – name and age.Age can be left unspecified
        //(may contain null value.Override ToString() to display the information of a person and if age is not specified
        //    – to say so.
        //Write a program to test this functionality.
        //Problem 5. ICloneable for Hotel (Hotel should have a list of Rooms)

        static void Main(string[] args)
        {
            Student student1 = new Student("Ionescu", "Alin", "Iulian", 10000, "Iasi", 0741231212, "alin12@gmail.com", 4, Universities.GheorgheAsachi, Specialities.BazeDeDate, Faculties.Informatica);
            Student student2 = new Student("Popescu", "Mihai", "Ilie", 10001, "Vaslui", 0751234567, "mihai@gmail.com", 1, Universities.AlexandruIoanCuza, Specialities.ChimieMedicala, Faculties.Chimie);
            Student student3 = new Student("Niculescu", "Vasile", "Mirel", 10002, "Vaslui", 0761242356, "vasile@gmail.com", 1, Universities.Agricultura, Specialities.Biochemistry, Faculties.Zootehnie);
           
            Student student4 = student3.Clone() as Student;

            Console.WriteLine( "First student :");
            Console.WriteLine(student1);

            Console.WriteLine("Second student :");
            Console.WriteLine(student2);

            Console.WriteLine("Third student :");
            Console.WriteLine(student3);

            Console.WriteLine("Cloned student:");
            Console.WriteLine(student4);


            Console.WriteLine($"Student1 == student2 ? {Student.Equals(student1, student2)}");
            Console.WriteLine($"Student1 == student2 ? {student1 == student2}");
            Console.WriteLine($"Student1 != student2 ?  {student1 != student2}");


            Console.WriteLine($"Student1 == student3 ? { Student.Equals(student1, student3)}");
            Console.WriteLine($"Student1 ==  student3 ? { student1 == student3}");
            Console.WriteLine($"Student1 !=  student3 ? {student1 != student3}");

            Console.WriteLine($"Student3 == student4? { Student.Equals(student3, student4)}");
            Console.WriteLine($"Student3 ==  student4 ? { student3 == student4}");
            Console.WriteLine($"Student3 !=  student4 ? {student3 != student4}");




            Console.WriteLine("Exercitiul4");
            Person person1 = new Person("Camelia", 20);
            Person person2= new Person("Maria", null);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }

    }
}

 