
namespace CRUDBook
{
    /*IV.Create a console app named CrudBookApp to connect to a local database.
      1.Use SQL parameters for that
      2.Print the inserted id (Execute scalar with select identity)
      3.Update a book (read id from console) 
      4.Delete a book (read id from console)
      5.Select a book (read id from console)*/

    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new PublisherT();
            publisher.Insert();
            publisher.Print();

            var book = new BookT();
            book.Update();
            book.Delete();
            book.Select();

        }
    }



}
