using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul16
    {
        public void exercitiul16()
        {
            //16. Write a C# program to compute the sum of the first 500 prime numbers.

            int number = 2;
            int count = 0;
            int sum = 0;
            while (count < 500)
            {
                if (Prime(number))
                {
                    sum = sum + number;
                    count++;
                }
                number++;
            }
            Console.WriteLine("The sum of the first 500 prime numbers is:" + sum);
            Console.ReadLine();
        }

        private static Boolean Prime(int number)
        {

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;


        }

    }
}
