using System;
using System.Collections.Generic;
using System.Text;

namespace tema3
{
    class Exercitiul4

    {
        public void exercitiul4()
        {
            //04.Homework 4
            //1.Find common elements between two arrays of integers.
            //2.Write a function to check if a number is prime or not.

            int[] numbers1 = new int[10];
            int[] numbers2 = new int[10];
            int common_numbers = 0;
            Console.WriteLine("Input 10 numbers for first array:");
            for (int x = 0; x < 10; x++)
            {
                Console.Write(" index - {0} : ", x);
                numbers1[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input 10 numbers for the second array: ");
             for( int y = 0; y < 10; y++)
             {
                 Console.Write("index - {0} :" , y);
                 numbers2[y] = int.Parse(Console.ReadLine());
             }

            foreach (int value_from_array1 in numbers1)
            {
                foreach (int value_from_array2 in numbers2)
                {
                    if (value_from_array1 == value_from_array2)
                    {
                        Console.WriteLine("Common number: " + value_from_array2);
                        common_numbers++;
                        break;
                    }
                    
                }
            }
            Console.WriteLine($" The number of common items is: {common_numbers}"); 

            //2.Write a function to check if a number is prime or not.


            foreach (int number in numbers1)
            {
                if (Prime(number))
                {
                    Console.WriteLine(number + " is prime");

                }
                else
                {
                    Console.WriteLine(number + " is not prime");
                }

            }

            foreach (int number in numbers2)
            {
                if (Prime(number))
                {
                    Console.WriteLine(number + " is prime");

                }
                else
                {
                    Console.WriteLine(number + " is not prime");
                }

            }

            Console.ReadKey();
        }
       
         private static Boolean Prime(int number)
         {

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0 )
                {
                    return false;
                }
                
                
            }
            return true;




























    }    }
    
}
