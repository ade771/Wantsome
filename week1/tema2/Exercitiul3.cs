using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class Exercitiul3
    {
        public void exercitiul3()
        {
            // Exercitiul 3

            /*read a number from the keyboard and

              - it is the temperature in c, convert it to f


                -it is the temperature in f, convert it to c


              -it is a number of days, convert it to years, months, weeks and days


            conventions - year: 365 days, month: 30 days, week: 7 days, use only numbers*/

            Console.WriteLine("Exercitiul 3");
            Console.WriteLine("Enter the temperature in Celsius ");

            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = (Celsius * 1.8) + 32;

            Console.WriteLine("Fahrenheit:" + Fahrenheit);

            Console.WriteLine("Enter the  temperature in Fahrenheit");
            double Fahrenheit1 = Convert.ToDouble(Console.ReadLine());
            double Celsius1 = (Fahrenheit1 - 32) / 1.8;

            Console.WriteLine("Celsius:" + Celsius1);

            Console.WriteLine("Enter the number of days");
            int days = Convert.ToInt32(Console.ReadLine());

            if (days >= 1000)
            {
                int years = days / 365;
                int months = (days - (years * 365)) / 30;
                int weeks = (days - ((years * 365) + (months * 30))) / 7;
                int days_left = days - ((years * 365) + (months * 30) + (weeks * 7));
                Console.WriteLine("Years :" + years);
                Console.WriteLine("Months :" + months);
                Console.WriteLine("Weeks:" + weeks);
                Console.WriteLine("Days :" + days_left);
            }
            else
            {
                Console.WriteLine(" Please introduce a number bigger than 1000");
            }
            Console.ReadLine();
        }
    }
}
