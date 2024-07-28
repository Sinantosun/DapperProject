using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.SpecialDtos;

namespace DapperProject.Services.SpecialServices
{
    public class SpecialService : ISpecialService
    {
        private readonly DapperContext _context;

        public SpecialService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateSpecialAsync(CreateSpecialDto SpecialDto)
        {
            var query = "insert into Specials (SpecialName,Title,Description,ImageUrl) values (@SpecialName,@Title,@Description,@ImageUrl)";
            var parametres = new DynamicParameters(SpecialDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteSpecialAsync(int id)
        {
            var query = "delete from Specials where SpecialId = @SpecialId";
            var parametres = new DynamicParameters();
            parametres.Add("@SpecialId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultSpecialDto>> GetAllSpecialsAsync()
        {
            var query = "select * from Specials";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultSpecialDto>(query);
            return values.ToList();
        }

        public async Task<ResultSpecialByIdDto> GetSpecialByIdAsync(int id)
        {
            var query = "select * from Specials where SpecialId=@SpecialId";
            var parametres = new DynamicParameters();
            parametres.Add("@SpecialId", id);
            var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultSpecialByIdDto>(query, parametres);

        }

        public async Task UpdateSpecialAsync(UpdateSpecialDto SpecialDto)
        {
            var query = "update Specials set SpecialName = @SpecialName,Title = @Title,Description =@Description,ImageUrl = @ImageUrl  where  SpecialId=@SpecialId";
            var parametres = new DynamicParameters(SpecialDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
