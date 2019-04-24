using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection(string connectionName)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}

