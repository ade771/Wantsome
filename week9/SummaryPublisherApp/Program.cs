
namespace SummaryPublisherApp
{
    // III. Create a new console app named SummaryPublisherApp.Here print to console:
    //1.Number of rows from the Publisher table (Execute scalar)
    //2.Top 10 publishers (Id, Name) (SQL Data Reader)
    //3.Number of books for each publisher(Publisher Name, Number of Books)
    //4.The total price for books for a publisher

    class Program
    {

        static void Main(string[] args)
        {
            var publisherT = new Publisher();
            var bookT = new Book();

            publisherT.ReadRow();
            publisherT.ReadTopTenPublishers();
            bookT.InsertAndGetNumberOfBooks();
            bookT.GetTotalPriceForBooks();


        }
    }
}


