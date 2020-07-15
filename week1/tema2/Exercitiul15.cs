using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul15

    {
  //15. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back



        public void exercitiul15()
        {
            Console.WriteLine("Exercitiul 15");
            Console.Write("Input a string : ");
            string text = Console.ReadLine();
            if (text.Length >= 1)
            {
                var s = text.Substring(0, 1);
                Console.WriteLine(s + text + s);

            }
            Console.ReadKey();
        }
    }
}
