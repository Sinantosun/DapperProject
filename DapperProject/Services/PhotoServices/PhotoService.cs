using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.PhotoDtos;

namespace DapperProject.Services.PhotoServices
{
    public class PhotoService : IPhotoService
    {
        private readonly DapperContext _context;

        public PhotoService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreatePhotoAsync(CreatePhotoDto PhotoDto)
        {
            var query = "insert into Photos (ImageUrl) values (@ImageUrl)";
            var parametres = new DynamicParameters(PhotoDto);
            var connection = _context.CreateConnection();

            await connection.ExecuteAsync(query, parametres);   
        }

        public async Task DeletePhotoAsync(int id)
        {
            var query = "delete from Photos where PhotoId = @PhotoId";
            var parametres = new DynamicParameters();
            parametres.Add("@PhotoId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query,parametres);

        }

        public async Task<List<ResultPhotoDto>> GetAllPhotosAsync()
        {
            var query = "select * from Photos";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPhotoDto>(query);
            return values.ToList();
        }

        public async Task<ResultPhotoByIdDto> GetPhotoByIdAsync(int id)
        {
            var query = "select * from Photos where PhotoId = @PhotoId";
            var parametres = new DynamicParameters();
            parametres.Add("@PhotoId", id);
            var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultPhotoByIdDto>(query,parametres);
            
        }

        public async Task UpdatePhotoAsync(UpdatePhotoDto PhotoDto)
        {
            var query = "update Photos set ImageUrl = @ImageUrl  where PhotoId = @PhotoId ";
            var parametres = new DynamicParameters(PhotoDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
