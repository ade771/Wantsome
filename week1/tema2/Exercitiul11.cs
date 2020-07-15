using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul11
    {

        //11. Print the Fibonacci sequence from 0 to 50. (i.e. Every next number is found by adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ..


        
            public int Fibonacci(int n)
            {
                int first_number = 0;
                int second_number = 1;

                for (int i = 0; i < n; i++)
                {
                int temporary_value = first_number;
                first_number = second_number;
                second_number = temporary_value + second_number;
                }
                return first_number;
            }

            public void exercitiul11()
            {
               Console.WriteLine("Exercitiul 3");
                 for (int i = 0; i < 10; i++)
                 {
                    Console.WriteLine(Fibonacci(i));
                 }

                Console.ReadKey();

            }






        



    }
}
