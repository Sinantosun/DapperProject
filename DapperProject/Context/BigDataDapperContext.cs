using System.Data.SqlClient;
using System.Data;

namespace DapperProject.Context
{
    public class BigDataDapperContext
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public BigDataDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("BigDataDapperConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
