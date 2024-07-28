using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.AboutDtos;

namespace DapperProject.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly DapperContext _dapperContext;

        public AboutService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public async Task CreateAboutAsync(CreateAboutDto AboutDto)
        {

            var query = "insert into Abouts (Title,TopDescription,Property1,Property2,Property3,BottomDescription,ImageUrl) values (@Title,@TopDescription,@Property1,@Property2,@Property3,@BottomDescription,@ImageUrl)";
            var parametres = new DynamicParameters(AboutDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteAboutAsync(int id)
        {
            var query = "delete from Abouts where AboutId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<ResultAboutByIdDto> GetAboutByIdAsync(int id)
        {
            var query = "select * from Abouts where AboutId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultAboutByIdDto>(query, parametres);
        }

        public async Task<List<ResultAboutDto>> GetAllAboutsAsync()
        {
            var query = "select * from Abouts";

            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultAboutDto>(query);
            return values.ToList();
        }

        public async Task UpdateAboutAsync(UpdateAboutDto AboutDto)
        {
            var query = "update Abouts set Title = @Title , TopDescription = @TopDescription,Property1 = @Property1,Property2 = @Property2,Property3=@Property3,BottomDescription=@BottomDescription,ImageUrl=@ImageUrl  where @AboutId = @AboutId";
            var parametres = new DynamicParameters(AboutDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
