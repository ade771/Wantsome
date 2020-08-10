using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Professor
    {
        private string nume;
        private string facultate;
        private string specializare;
        private static int nrProfesori;
       public void PrintProfessor()
        {
            Console.WriteLine($"I am proffesor from faculty{facultate}, specialization{specializare}");
        }
        public Professor()
        {
            nrProfesori++;
        }

        public Professor(string nume, string facultate,string specializare)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.specializare = specializare;
            nrProfesori++;
        }
        public static void PrintProfesori()
        {
            Console.WriteLine($"{nrProfesori} profesori");
        }






    }

}
