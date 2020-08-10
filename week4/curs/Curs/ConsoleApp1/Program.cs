using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor("Ionescu", "FEAA", "AgroEconomie");
            Professor.PrintProfesori();
        }
    }
}
