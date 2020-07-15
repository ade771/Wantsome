using System;
using System.Collections.Generic;
using System.Text;

namespace tema3
{
    class Exercitiul1
    {
        public void exercitiul1()
        {
            // 01.FizzBuzz


            //For all numbers from 1 to 1000, print the following:
            //-If number is divisible by 3, print Fizz
            //-If number is divisible by 5, print Buzz
            //-If number is divisible by 3 and 5, print FizzBuzz
            //-Otherwise, print the number
            
            for( int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZ-BUZZ");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ" );
                }

                else if( i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }

                else
                {
                    Console.WriteLine( i );
                }
            }
            Console.ReadKey();













        }
    }
}
