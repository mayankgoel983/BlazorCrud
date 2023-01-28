using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BlazorCrud.SqlServer
{
    public class Context
    {
        public IConfiguration _configuration;
        private string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
