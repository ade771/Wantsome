using System;


namespace Tema5si6
{
    class Ex3
    {
        //How to calculate factorial using recursion in C# + iterative + time difference.
       //1.Recursion method
        static int factorialRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
           return n * factorialRecursion(n - 1);
        }
       
        //2. Iteration method
        static int factorialIteration(int n)
        {
            int result = 1;
            int i;
            for (i = 2; i <= n; i++)
            {
                result *= i;
            }
           return result;
        }
        public void ex3()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of " + number + " using Recursion: " + factorialRecursion(number));
            Console.WriteLine("Factorial of " + number + " using Iteration: " + factorialIteration(number));
        }

    }
}

