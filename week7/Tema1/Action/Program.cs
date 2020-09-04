using System;

namespace Action
{
    class Program
    {
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            //Anonymous method with Action delegate
            Action<int> printActionDel1 = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel1(10);

            // Lambda expression with Action delegate
            Action<int> printActionDel2 = i => Console.WriteLine(i);

            printActionDel2(10);
        }
    }
}
