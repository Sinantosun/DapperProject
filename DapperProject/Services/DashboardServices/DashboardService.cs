using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.DashboardDtos;

namespace DapperProject.Services.DashboardServices
{
    public class DashboardService : IDashboardService
    {
        //select top 1 * from Products order by  ProductPrice desc

        private readonly DapperContext _dapperContext;

        public DashboardService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<ResultDashboardStatisticDto> GetResultDashboardStatisticDto()
        {
            var connection = _dapperContext.CreateConnection();

            var chepeerProductPriceQuery = "select min(ProductPrice) from Products";
            var ExpensiveProductNameQuery = "select top 1 ProductName  from Products order by ProductPrice desc";
            var ExpensiveProductPriceQuery = "select top 1 ProductPrice  from Products order by ProductPrice desc";
            var ProductAvgPriceQuery = "Select Avg(ProductPrice) from Products";
            var ProductCountQuery = "select count(*) from Products";
        
            var chepeerProductPriceQueryResult = await connection.QueryAsync<decimal>(chepeerProductPriceQuery);
            var ExpensiveProductNameQueryResult = await connection.QueryAsync<string>(ExpensiveProductNameQuery);
            var ExpensiveProductPriceQueryResult = await connection.QueryAsync<decimal>(ExpensiveProductPriceQuery);
            var ProductAvgPriceQueryResult = await connection.QueryAsync<decimal>(ProductAvgPriceQuery);
            var ProductCountQueryResult = await connection.QueryAsync<int>(ProductCountQuery);

            return new ResultDashboardStatisticDto
            {
                CheeperProductPrice = chepeerProductPriceQueryResult.FirstOrDefault(),
                ExpensiveProductName = ExpensiveProductNameQueryResult.FirstOrDefault(),
                ExpensiveProductPrice = ExpensiveProductPriceQueryResult.FirstOrDefault(),
                ProductAvgPrice = ProductAvgPriceQueryResult.FirstOrDefault(),
                ProductCount = ProductCountQueryResult.FirstOrDefault(),
            };

        }
    }
}
