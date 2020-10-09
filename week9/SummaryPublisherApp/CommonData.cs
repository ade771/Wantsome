
using System.Data.SqlClient;


namespace SummaryPublisherApp
{
    public static class CommonData
    {
        public static SqlConnection GiveCommonCode()
        {
            var connectionString1 = @"Server=DESKTOP-P96SQTC\MSSQLSERVER01;Database=DataBaseForTema11;Trusted_Connection=True;";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();

            return connection1;
        }

    }
}
