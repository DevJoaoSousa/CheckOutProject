using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Infrastructure.Factory
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection Create() => new SQLiteConnection("data source=C:\\CheckOut_PaymentGateway\\CheckOut_PaymentGateway\\CheckOut_Database.db;Version=3;");
    }
}
