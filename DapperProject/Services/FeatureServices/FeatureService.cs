using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.FeatureDtos;

namespace DapperProject.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly DapperContext _context;

        public FeatureService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateFeatureAsync(CreateFeatureDto FeatureDto)
        {
            var query = "insert into Features (Title,Description,ImageUrl,IframeUrl) values (@Title,@Description,@ImageUrl,@IframeUrl)";
            var parametres = new DynamicParameters(FeatureDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteFeatureAsync(int id)
        {
            var query = "delete from Features where FeatureId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }

        public async Task<List<ResultFeatrueDto>> GetAllFeaturesAsync()
        {
            var query = "select * from Features";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultFeatrueDto>(query);
            return values.ToList();
        }

        public async Task<ResultFeatureByIdDto> GetFeatureByIdAsync(int id)
        {
            var query = "select * from Features where FeatureId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultFeatureByIdDto>(query,parametres);
        }

        public async Task UpdateFeatureAsync(UpdateFeatureDto FeatureDto)
        {
            var query = "update Features set Title = @Title,Description = @Description,ImageUrl = @ImageUrl,IframeUrl = @IframeUrl where FeatureId = @FeatureId";
            var parametres = new DynamicParameters(FeatureDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
