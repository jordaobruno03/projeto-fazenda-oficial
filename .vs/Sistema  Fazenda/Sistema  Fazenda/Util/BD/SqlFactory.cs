using System.Data;
using System.Data.SqlClient;


namespace Sistema__Fazenda.Util.BD
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection();
        }
    }
}
