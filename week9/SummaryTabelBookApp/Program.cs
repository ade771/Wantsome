using System;

namespace SummaryTabelBookApp
{
    /*V.Create a console app named SummaryBookApp to connect to a local database. Here print to console.
      1.All the books that are published in 2010
      2.The book that is published in the max year (can use multiple commands)
       3.Top 10 books (Title, Year, Price)*/
   
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookTabel();
            book.PrintBooks();
            book.GetBookMaxYear();
            book.PrintFirstTenBooks();
        }
    }
}
