using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul12
    {

        //12.Write a C# Sharp program to print on screen the output of adding, subtracting, 
        //multiplying and dividing of two numbers which will be entered by the user

       public void exercitiul12()
       {
            Console.WriteLine("Exercitiul 12");
            Console.WriteLine("Input the first number:");
            double first_number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Input the second number:");
            double second_number = Convert.ToDouble(Console.ReadLine());

            double add = first_number + second_number;
            double substract = first_number - second_number;
            double multiply = first_number * second_number;
            double divide = first_number / second_number;
            double mod = first_number % second_number;

            Console.WriteLine("The result of adding is: " + add);
            Console.WriteLine("The result of substracting is: " + substract);
            Console.WriteLine("The result of multiply is: " + multiply);
            Console.WriteLine("The result of dividing is: " + divide);
            Console.WriteLine("The result of module is: " + mod);
            Console.ReadKey();
        }
    }
}
