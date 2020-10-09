using System;
using System.Data.SqlClient;
using SummaryPublisherApp;

namespace SummaryTabelBookApp
{
    public class BookTabel
    {
        public void PrintBooks()
        {
            Console.WriteLine("********1.All the books that are published in 2010*****");

            try
            {
                Console.WriteLine("Input year of books which you want to select:");
                var year1 = int.Parse(Console.ReadLine());

                var commandTextB = $"select *from Book2 where year = @year1Param";
                var commandB = new SqlCommand(commandTextB);

                var yearParamObject = new SqlParameter("year1Param", year1);
                commandB.Parameters.Add(yearParamObject);
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

        public void GetBookMaxYear()
        {
            Console.WriteLine("***2.The book that is published in the max year(can use multiple commands)**");

            try
            {
                var commandTextD = $"SELECT Title,[Year] FROM Book " +
                                   "WHERE [Year] = (SELECT MAX([Year] ) FROM Book)";

                var commandD = new SqlCommand(commandTextD);
                commandD.Connection = CommonData.GiveCommonCode();

                using (var reader = commandD.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var title = reader[0];
                        var year = reader[1];


                        Console.WriteLine($"{title},{year}");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void PrintFirstTenBooks()
        {
            Console.WriteLine("******* 3.Top 10 books (Title, Year, Price)***********");
           
            try
            {
                var commandTextD = $"SELECT Title,[Year], Price FROM Book " +
                                    "WHERE  BookId < 11";

                var commandD = new SqlCommand(commandTextD);
                commandD.Connection = CommonData.GiveCommonCode();

                using (var reader = commandD.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var title = reader[0];
                        var year = reader[1];
                        var price = reader[2];

                        Console.WriteLine($"{title},{year},{price}");
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