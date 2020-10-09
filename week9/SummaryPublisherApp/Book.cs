using System;
using System.Data.SqlClient;


namespace SummaryPublisherApp
{
    public class Book
    {
        public void InsertAndGetNumberOfBooks()
        {
            Console.WriteLine("**************3.Number of books for each publisher(Publisher Name, Number of Books************");


            var commandText1 =
              "insert into Book values ( 'To kill a mockingbird', 1, 1960, 36)" +
              "insert into Book values ( 'Harry Potter and the philosophers stone',1,2000,45)" +
              "insert into Book values ( 'The lord of the rings',1,2001,55)" +
                "insert into Book values ( 'The great gatsby',2,1925,39)" +
              "insert into Book values ( 'Pride and prejudice',3,1940,49)" +
            "insert into Book values ( 'The diary of the a young girl',4,1950,55)" +
               "insert into Book values ( 'The book thief',4,1939,44)" +
              "insert into Book values ( 'The hobbit',5,1998,56)" +
               "insert into Book values ( 'The little women',5,1999,60)" +
             "insert into Book values ( 'Fahrenheit 451',5,1984,49)" +
             "insert into Book values ( 'Jane Eyre',5,1989,40)" +
               "insert into Book values (' Animal Farm',6,1945,38)" +
               "insert into Book values ( 'Gone with the Wind',7,1940,45)" +
            "insert into Book values (' The Catcher in the Rye',8,1942,57)" +
             "insert into Book values ('Charlotte’s Web',8,1966,61)" +
            "insert into Book values (' The Lion, the Witch, and the Wardrobe',9,2001,29)" +
              "insert into Book values ('The Grapes of Wrath',10,2002,30)" +
              "insert into Book values ('Lord of the Flies',10,2003,31)" +
                "insert into Book values ('The Kite Runner',10,2004,32)" +
              "insert into Book values ('Of Mice and Men',10,2005,33)" +
            "insert into Book values ('A Tale of Two Cities',11,2006,44)" +
               "insert into Book values ('Romeo and Juliet',12,1950,51)" +
              "insert into Book values ('The Hitchhikers Guide to the Galaxy',12,1952,66)" +
               "insert into Book values (' Wuthering Heights',12,1847,67)" +
             "insert into Book values ('The Color Purple',12,1901,68)" +
             "insert into Book values ('Alice in Wonderland',13,1903,41)" +
               "insert into Book values ('Frankenstein',13,1899,29)" +
               "insert into Book values ('The Adventures of Huckleberry Finn',14,1900,30)" +
            "insert into Book values ('Slaughterhouse-Five',14,1903,26)" +
             "insert into Book values ('The Scarlet Letter',15,1879,44)";

            var command1 = new SqlCommand(commandText1);
            command1.Connection = CommonData.GiveCommonCode();
            var result1 = command1.ExecuteScalar();
            Console.WriteLine($"Response: {result1}");


            try
            {
                var commandTextB = "SELECT Publisher.[Name],COUNT(*) NumberofBooks FROM Book " +
                                   "INNER JOIN Publisher ON Book.publisherid = Publisher.publisherid " +
                                   "GROUP BY Publisher.[Name]";

                var commandB = new SqlCommand(commandTextB);
                commandB.Connection = CommonData.GiveCommonCode();

                using (var reader = commandB.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader[0];
                        var NumberOfBooks = reader[1];

                        Console.WriteLine($"{name}, {NumberOfBooks}");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GetTotalPriceForBooks()
        {
            Console.WriteLine("**************4.The total price for books for a publisher********");
           
            try
            {
                var commandTextC = "SELECT Publisher.[Name],SUM(Book.Price) TotalPrice " +
                                   "FROM Book " +
                                   "INNER JOIN Publisher ON Publisher.PublisherId = Book.PublisherId " +
                                   "GROUP BY Publisher.[Name]";

                var commandC = new SqlCommand(commandTextC);
                commandC.Connection = CommonData.GiveCommonCode();

                using (var reader = commandC.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader[0];
                        var TotalPrice = reader[1];

                        Console.WriteLine($"{name}, {TotalPrice}");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}

