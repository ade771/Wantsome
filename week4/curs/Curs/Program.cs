using System;

namespace Curs
{
    class Program
    {
        static void Main(string[] args)
        {

            //author arghezi = new author();
            // author creanga = new author("creanga", "creanga@yahoo.com", 2);
            //arghezi.PrintAuthor();
            //creanga.PrintAuthor();
            //Book b1 = new Book();
            //b1.PrintBook();
            //Console.WriteLine("=====================================");
            //Book b2 = new Book("Dama cu camelii", 1863,17.99);
            //b2.PrintBook();
            //Book b3 = new Book("Amintiri din copilarie",creanga, 1990, 77);
            //Book b4 = new Book("Morometii ", "Marin Preda", "marin@yahoo.com",7,45);
            //b4.PrintBook();


            Book b2 = new Book("It", 1997, 12.5);
            Library l1 = new Library();
            Library l2 = new Library("Iasi", b2);
        }
    }
}
