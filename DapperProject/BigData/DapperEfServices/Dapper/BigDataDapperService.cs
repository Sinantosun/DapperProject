using Dapper;
using DapperProject.BigData.Dtos.DapperDtos;
using DapperProject.Context;

namespace DapperProject.BigData.DapperEfServices.Dapper
{
    public class BigDataDapperService : IBigDataDapperService
    {
        private readonly BigDataDapperContext _context;

        public BigDataDapperService(BigDataDapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ResultBigDataDto>> GetDataWithUsingDapperAsync()
        {
            var query = "select * from SALES";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultBigDataDto>(query);
            return values;
        }
    }
}
