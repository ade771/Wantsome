using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul14
    {

        public void exercitiul14()
        {
            // 14.Write a C# Sharp program that takes four numbers as input to calculate and print the average
            Console.WriteLine("Exercitiul 14");
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;

            }
            Console.WriteLine("The average is: " + (double)sum / 4);

            Console.ReadKey();
        }
    }
}
