using System;


namespace Tema2
{
    class Ex2
    {

       
        
        public void ReadNumber(int start, int end)
        {
            int count = 1;
            int number;
            do
            {
                Console.Write("Number{0}: ", count);
                number = int.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
        }

    }
        
}

