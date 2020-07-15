using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul10
    {
        //10. Print numbers from 1 to 10 except 4 and 7.
        public void exercitiul10()


        {
            Console.WriteLine("Exercitiul 10");
            for (int x = 1; x <= 10; x++)
            {
                if (x == 4 || x == 7)
                {
                    continue;
                }
                Console.WriteLine(x);
            }

            Console.ReadLine();


        }

    }
}
