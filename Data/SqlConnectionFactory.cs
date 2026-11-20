using Microsoft.Data.SqlClient;
namespace CRUD.Data
{
    public class SqlConnectionFactory
    {
        public static SqlConnectionFactory Instance { get; } = new();

        private SqlConnectionFactory() { }

        public SqlConnection CreateConnection()
        {
            return new("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=school_db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
    }
}
