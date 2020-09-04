using System;

namespace Predicate
{
    class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);


            //Predicate delegate with anonymous method
            Predicate<string> isUpper1 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result1 = isUpper("hello world!!");



            //Predicate delegate with lambda expression
            Predicate<string> isUpper2 = s => s.Equals(s.ToUpper());
            bool result2 = isUpper("hello world!!");


        }

    }
}
