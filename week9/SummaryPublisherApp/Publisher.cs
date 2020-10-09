using System;
using System.Data.SqlClient;

namespace SummaryPublisherApp
{
    public class Publisher
    {

        public void ReadRow()
        {
            Console.WriteLine("************1.Number of rows from the Publisher table (Execute scalar)*****************");

            string stmt = "SELECT COUNT(*) FROM dbo.Publisher";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Server=DESKTOP-P96SQTC\MSSQLSERVER01;Database=DataBaseForTema11;Trusted_Connection=True;"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }

            Console.WriteLine($"The Publisher  table has: {count} rows");
            Console.WriteLine();
        }

        public void ReadTopTenPublishers()
        {


            try
            {
                var commandTextA = $"select publisherid, name" +
                                   " from Publisher " +
                                   "where (publisherid < 11)";

                var commandA = new SqlCommand(commandTextA);
                commandA.Connection = CommonData.GiveCommonCode();

                using (var reader = commandA.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader[0];
                        var name = reader[1];

                        Console.WriteLine($"{id}, {name}");
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
