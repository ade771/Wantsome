using SummaryPublisherApp;
using System;
using System.Data.SqlClient;


namespace CRUDBook
{
    public class PublisherT
    {

        public void Insert()
        {
            try
            {
                Console.WriteLine("Insert the publisherId:");
                var id = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert the publisher Name");
                var name = Console.ReadLine();

                Console.WriteLine("Input nr of books");
                var nrOfBooks = int.Parse(Console.ReadLine());

                Console.WriteLine("Input total price:");
                var totalPrice = decimal.Parse(Console.ReadLine());

                var commandText = $"insert into Publisher values (@PublisherIdParam, @NameParam,@NrOfBooks,@TotalPrice)";
                var command = new SqlCommand(commandText);

                var PublisherIdParamObject = new SqlParameter("PublisherIdParam", id);
                var nameParamObject = new SqlParameter("NameParam", name);
                var NrOfBooksParamObject = new SqlParameter("NrOfBooks", nrOfBooks);
                var TotalPriceParamObject = new SqlParameter("TotalPrice", totalPrice);

                command.Parameters.Add(PublisherIdParamObject);
                command.Parameters.Add(nameParamObject);
                command.Parameters.Add(NrOfBooksParamObject);
                command.Parameters.Add(TotalPriceParamObject);

                command.Connection = CommonData.GiveCommonCode(); 

                var result = command.ExecuteNonQuery();
                Console.WriteLine($"Insert: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void Print()
        {
            try
            {
                var commandTextB = "SELECT TOP 1 * FROM Publisher ORDER BY Publisherid DESC";
                var commandB = new SqlCommand(commandTextB);
                commandB.Connection = CommonData.GiveCommonCode();

                using (var reader = commandB.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader[0];
                        var name = reader[1];
                        var nrOfBooks = reader[2];
                        var totalprice = reader[3];
                        Console.WriteLine($"{id}, {name},{nrOfBooks},{totalprice}");
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


