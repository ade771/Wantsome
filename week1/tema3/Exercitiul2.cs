using System;
using System.Collections.Generic;
using System.Text;

namespace tema3
{
    class Exercitiul2
    {
        public void exercitiul2()
        {
            //02.Write a program to count the frequency of each element in an array e.g. [1, 4, 5, 2, 1, 4, 3, 1, 2]

            int[] numbers = new int[5];
            int[] frequency = new int[5];
            Console.Write("Input 5 numbers:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" index -{0} : ", i);
                numbers[i] = int.Parse(Console.ReadLine());
                frequency[i] = -1;
            }

            for (int i = 0; i < 5; i++)
            {
                int counter = 1;
                for (int x = i + 1; x < 5; x++)
                {
                    if (numbers[i] == numbers[x])
                    {
                        counter++;
                        frequency[x] = 0;
                    }
                }

                if (frequency[i] != 0)
                {
                    frequency[i] = counter;
                }
            }
            
            for(int i = 0; i < 5; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(" number - {0} :{1} times\n", numbers[i], frequency[i]);
                }
            }
            Console.ReadKey();











        }
    }

}
