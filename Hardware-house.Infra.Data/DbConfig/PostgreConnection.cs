using Npgsql;

namespace Hardware_house.Infra.Data.DbConfig
{
    public class PostgreConnection
    {
        protected NpgsqlCommand npgsqlCommand;
        protected NpgsqlDataReader npgsqlDataReader;
        private NpgsqlConnection conn = new NpgsqlConnection("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=oficinadb;User Id=professor;Password=professor;");

        protected void OpenConnection()
        {
            conn.Open();
        }

        protected void CloseConnection()
        {
            conn.Close();
        }
    }
}
