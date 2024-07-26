using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.CategoryDtos;

namespace DapperProject.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {

        private readonly DapperContext _dapperContext;

        public CategoryService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            string query = "insert into categories (CategoryName) values (@categoryName)";
            var parametres = new DynamicParameters();
            parametres.Add("@categoryName", categoryDto.CategoryName);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }

        public async Task DeleteCategoryAsync(int id)
        {
            string query = "delete from categories where CategoryId = @categoryId";
            var parametres = new DynamicParameters();
            parametres.Add("@categoryId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            string query = "select * from categories";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            return values.ToList();
        }

        public async Task<ResultCategoryByIdDto> GetCategoryByIdAsync(int id)
        {
            string query = "select * from categories where CategoryId = @CategoryId";
            var parametres = new DynamicParameters();
            parametres.Add("@CategoryId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultCategoryByIdDto>(query, parametres);



        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            var query = "update categories set CategoryName = @CategoryName where CategoryId = @CategoryId";
            var parametres = new DynamicParameters(categoryDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }
    }
}
