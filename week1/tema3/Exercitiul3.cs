using System;
using System.Collections.Generic;
using System.Text;

namespace tema3
{
    class Exercitiul3
    {
        public void exercitiul3()
        {
            // 03.Read an array from the console and separate odd and even values into 2 arrays.

            int[] numbers1 = new int[10];
            int[] numbers2 = new int[10];
            int[] numbers3 = new int[10];
           
            Console.WriteLine("Input 10 numbers:");
            int y = 0;
            int z = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.Write(" {0} : ", x);
                numbers1[x] = int.Parse(Console.ReadLine());
                
            }

            for(int x = 0; x < 10; x++)
            {
                if (numbers1[x] % 2 == 0 )
                {
                    numbers2[y] = numbers1[x];
                      y++;
                }
                else
                {
                    numbers3[z] = numbers1[x];
                    z++;
                }
            }

            Console.WriteLine("The Even numbers:");
            for (int x = 0; x < y; x++)
            {
                Console.WriteLine( numbers2[x]);
            }

            Console.WriteLine("The Odd numbers :");
            for (int x = 0; x < z; x++ )
            {
                Console.WriteLine( numbers3[x]);
            }
           
            Console.ReadKey();




        }
    }
}
