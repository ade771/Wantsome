using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Curs
{
    class Library
    {
        string adress;
        DateTime openingHour;
        DateTime closingHour;
        List<Book> books;

        public Library()
        {
            this.adress = "Iasi";
            this.openingHour = new DateTime(2020,07,28,7,7,0);
            this.closingHour = new DateTime(2020, 07, 28, 9, 9, 0);
            this.books = new List<Book>();
            

        }
        public Library(string adress, Book book)
        {
            this.adress = "Iasi";
            this.openingHour = new DateTime(2020, 07, 28, 7, 7, 0);
            this.closingHour = new DateTime(2020, 07, 28, 9, 9, 0);
            this.books = new List<Book>();
            //books.Add(book);
            //this.books.Add(book);
            this.books = new List<Book> { book };
        }

    }
}
