using System;

namespace Tema5si6
{
    class Ex9
    {
        //Write a function to count a total number of set bits in a 32-bit Integer
        public static int countBits(int n)
        {
            if (n == 0)
            {
                return 0;
            }            

            else
            {
                return (n & 1) + countBits(n >> 1);
            }
                
        }
        public void ex9()
        {
            Console.WriteLine("Enter a number : ");
           int number = Convert.ToInt32(Console.ReadLine());
           Console.Write(countBits(number));
        }

    }
}
