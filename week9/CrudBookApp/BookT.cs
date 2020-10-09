using SummaryPublisherApp;
using System;
using System.Data.SqlClient;


namespace CRUDBook
{
    public class BookT
    {
        public void Update()
        {
            try
            {
                Console.WriteLine("Title of the book:");
                var title = Console.ReadLine();

                Console.WriteLine("Publisherid: ");
                var publisherid = int.Parse(Console.ReadLine());

                Console.WriteLine("Year:");
                var year = int.Parse(Console.ReadLine());

                Console.WriteLine("Price:");
                var price = decimal.Parse(Console.ReadLine());

                var commandText = $"update Book2 set title = @titleParam, " +
                                 "year = @yearParam, price = @priceParam where publisherid = @publisheridParam";

                var command = new SqlCommand(commandText);

                var titleParamObject = new SqlParameter("titleParam", title);
                var publisheridParamObject = new SqlParameter("publisheridParam", publisherid);
                var yearParamObject = new SqlParameter("yearParam", year);
                var priceParamObject = new SqlParameter("priceParam", price);

                command.Parameters.Add(titleParamObject);
                command.Parameters.Add(publisheridParamObject);
                command.Parameters.Add(yearParamObject);
                command.Parameters.Add(priceParamObject);

                command.Connection = CommonData.GiveCommonCode();

                var result = command.ExecuteNonQuery();
                Console.WriteLine($"Update: {result}");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void Delete()
        {
            try
            {
                Console.WriteLine("Input title of book which you want to delete:");
                var title = Console.ReadLine();

                var commandText = $"delete from Book2 where title = @titleParam";
                var command = new SqlCommand(commandText);

                var titleParamObject = new SqlParameter("titleParam", title);
                command.Parameters.Add(titleParamObject);
                command.Connection = CommonData.GiveCommonCode();

                var result = command.ExecuteNonQuery();
                Console.WriteLine($"Delete: {result} books");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Select()
        {
            try
            {
                Console.WriteLine("Input title of book which you want to select:");
                var title1 = Console.ReadLine();

                var commandTextB = $"select *from Book2 where title = @title1Param";
                var commandB = new SqlCommand(commandTextB);
                var titleParamObject = new SqlParameter("title1Param", title1);
                commandB.Parameters.Add(titleParamObject);
                commandB.Connection = CommonData.GiveCommonCode();

                using (var reader = commandB.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bookid = reader[0];
                        var title = reader[1];
                        var Publisherid = reader[2];
                        var year = reader[3];
                        var price = reader[4];

                        Console.WriteLine($"{bookid}, {title},{Publisherid},{year},{price}");
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

