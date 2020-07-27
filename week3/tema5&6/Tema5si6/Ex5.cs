using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5si6
{
    class Ex5
    {
        //How to find sum of digits of a number using Recursion?
        static int sum(int n)
        {
            if (n == 0)
                return 0;

            return (n % 10 + sum(n / 10));
        }

        public void ex5()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int result = sum(number);
            Console.WriteLine("Sum of digits is "  + result);

        }
    }
}
