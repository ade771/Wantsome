using System;

namespace Tema5si6
{
    class Ex1
    {
        public void ex1()
        {
            //Given an array of ints, write a C# method to total all the values that are even number


            int[] array = new int[] {1,2,3,4,5,6,7,8,9};
            int count = 0;
            foreach(int Item in array)
            {
                if( Item % 2 == 0)
                {
                    count++;
                    Console.WriteLine("Even number: " + Item);
                }
            }
            Console.WriteLine("The total of even number is:" + count);
        }
    }
}
