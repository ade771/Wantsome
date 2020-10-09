using System;
using System.Data.SqlClient;

namespace InsertPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=DESKTOP-P96SQTC\MSSQLSERVER01;Database=DataBaseForTema11;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            var commandText12 =
           "insert into Publisher values (1, 'Adelina')" +
           "insert into Publisher values (2, 'Iuliana')" +
           "insert into Publisher values (3, 'Maria')" +
             "insert into Publisher values (4, 'Ana')" +
           "insert into Publisher values (5, 'Mihai')" +
         "insert into Publisher values (6, 'Mira')" +
            "insert into Publisher values (7, 'Marcel')" +
           "insert into Publisher values (8, 'Grigore')" +
            "insert into Publisher values (9, 'Anastasia')" +
          "insert into Publisher values (10, 'Alina')" +
          "insert into Publisher values (11, 'Bianca')" +
            "insert into Publisher values (12, 'Violeta')" +
            "insert into Publisher values (13, 'Mariana')" +
         "insert into Publisher values (14, 'Valeriu')" +
          "insert into Publisher values (15, 'Ariadna')";



            var command12 = new SqlCommand(commandText12);
            command12.Connection = connection;
            var result12 = command12.ExecuteScalar();

            Console.WriteLine($"Response: {result12}");

            try
            {
                var commandTextA = $"select publisherid, name from Publisher";
                var commandA = new SqlCommand(commandTextA);
                commandA.Connection = connection;

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

