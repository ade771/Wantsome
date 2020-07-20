using System;
namespace UpdateTema4
{
    class Exercitiul5

    {
        public void exercitiul5()
        {
            //5. Check if a word is a palindrome

            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            string  reverse;
            char[] FromStr = str.ToCharArray();
            Array.Reverse(FromStr);
            reverse = new string(FromStr);
            bool b = str.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(str + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine( str + " is not a Palindrome!");
            }
            Console.Read();













        }


    }
}
