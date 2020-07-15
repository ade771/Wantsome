using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul13

    {
        public void exercitiul13()
        {
            Console.WriteLine("Exercitiul 13");
            // 13.Write a C# Sharp program that takes a number as input and print its multiplication table.

            Console.WriteLine("Enter a number!");
              int number = Convert.ToInt32(Console.ReadLine());
              for(int i = 0; i <= 10; i++)
              {
                  Console.Write(number + " * " + i + " = " + number * i + "\n");
              }

              Console.ReadKey();
        }
    }
}
