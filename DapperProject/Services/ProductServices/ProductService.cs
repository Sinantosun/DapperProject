using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.ProductDtos;

namespace DapperProject.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DapperContext _dapperContext;

        public ProductService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateProductAsync(CreateProductDto ProductDto)
        {
            var query = "insert into products (ProductName,Description,ProductPrice,ImageURL,CategoryId) values (@ProductName,@Description,@ProductPrice,@ImageURL,@CategoryId)";
            var parametres = new DynamicParameters(ProductDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteProductAsync(int id)
        {
            string query = "delete from products where ProductId = @ProductId";
            var parametres = new DynamicParameters();
            parametres.Add("@ProductId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var query = "select ProductId,ProductName,Description,ProductPrice,ImageUrl,CategoryName from Products inner join Categories on Categories.CategoryId = Products.CategoryId";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultProductDto>(query);
            return values.ToList();
        }

        public async Task<ResultProductByIdDto> GetProductByIdAsync(int id)
        {
            var query = "select ProductId,ProductName,Description,ProductPrice,ImageUrl,CategoryName from Products inner join Categories on Categories.CategoryId = Products.CategoryId where ProductId=@ProductId";
            var parametres = new DynamicParameters();
            parametres.Add("@ProductId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultProductByIdDto>(query, parametres);

        }

        public async Task UpdateProductAsync(UpdateProductDto ProductDto)
        {
            var query = "update products set ProductName = @ProductName, Description =@Description,ProductPrice=@ProductPrice,ImageUrl=@ImageUrl,CategoryId=@CategoryId where ProductId  = @ProductId";
            var paramatres = new DynamicParameters(ProductDto);
            var connection =  _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, paramatres);
        }
    }
}
