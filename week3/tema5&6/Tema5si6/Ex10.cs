using System;
using System.Collections.Generic;


namespace Tema5si6
{
    class Ex10
    {
        //Write a function to remove duplicate characters from String
        public static String RemoveDublicates(String s)
        {
            String str = "";
            int len = s.Length; 
            for (int i = 0; i < len; i++)
            { 
                char c = s[i];
                if (str.IndexOf(c) < 0)
                {
                    str += c;
                }
            }

            return str;
        }

        public void ex10()
        {
            Console.WriteLine("Enter a string : ");
            string s = Console.ReadLine();
            
            Console.WriteLine(RemoveDublicates(s));

        }
    }
}
