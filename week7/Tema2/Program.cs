using System;

namespace Tema2
{
    class Program
    {
    //    1. Write a program that enters the file name along with its full file path
    //      (e.g.C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    //        Find in MSDN how to use System.IO.File.ReadAllText(...).
    //        Be sure to catch all possible exceptions and print user-friendly error messages.
        //2. Write a method ReadNumber(int start, int end) that enters an integer number in a given range
//            (start, end ).
//If an invalid number or non-number text is entered, the method should throw an exception.

//Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
//Output
//Print 1 < a1< ... < a10< 100
//Or Exception if the above inequality is not true



        static void Main(string[] args)
        {

            Ex1 ex1= new Ex1();
            ex1.ReadFile();

            Ex2 ex2 = new Ex2();

            Console.WriteLine("Enter the start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the end: ");
            int end = int.Parse(Console.ReadLine());

            if (end <= start + 10)
            {
                Console.WriteLine("Invalid input!");
            }
               
            else
            {
                ex2.ReadNumber(start, end);
            }
             





        }
    }
}
        