using System;

namespace Tema1
{
    public delegate void MyDelegate(string msg);
    public delegate T add<T>(T param1, T param2);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delA = ClassA.MethodA;
            delA("Acesta este un mesaj1!");
            MyDelegate delB1 = ClassB.MethodB;
            delB1("Aceste este un mesaj2!");
            MyDelegate delB2 = ClassB.MethodB;
            Invoke(delB2); //Passing Delegate as a Parameter

            //Multicast
         

            MyDelegate del = delA + delB1;
            del("Hello World");

            MyDelegate delC = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del += delC; 
            del("Hello World");

            del = del - delB1;
            del("Hello World");

            del -= delA;
            del("Hello World");

            static void Invoke(MyDelegate delB)
            {
                delB("Message");
            }


            add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            add<string> con = Concat;
            Console.WriteLine(con("Hello ", "World!!"));

        }
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
