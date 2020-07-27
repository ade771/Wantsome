using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5si6
{
    class Ex12
    {
        //C# program to check if a number is Armstrong number or not?
        public void ex12()
        {
            int temporary;
            int n = 0;
            int sum = 0;
          Console.Write("Enter the Number: ");
          int number = int.Parse(Console.ReadLine());
            temporary = number;
            while (number > 0)
            {
                n = number % 10;
                sum = sum + (n * n * n);
                number = number / 10;
            }
            if (temporary == sum)
            {
                Console.WriteLine("It's an Armstrong number");
            }
               
            else
            {
                Console.WriteLine("It's not an Armstrong number ");
            }
                
        }
    }
}

