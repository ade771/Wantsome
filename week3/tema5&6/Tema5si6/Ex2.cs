using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5si6
{
    class Ex2
    {
        public void ex2()
        {
            //    Find all pairs of elements in an integer array, whose sum is equal to a given number?[x]
            //     todo home: return the list of pairs as single return type

            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10 };
            int sum = 9;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        count++;
                        Console.WriteLine(array[i] + "+" + array[j] + "=" + sum);
                    }
                }
                
            }

            Console.WriteLine("Found : " + count + " pairs");











        }    
    }
}
