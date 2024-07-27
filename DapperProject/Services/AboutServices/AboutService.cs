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
        public Task CreateAboutAsync(CreateAboutDto AboutDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAboutAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultAboutByIdDto> GetAboutByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultAboutDto>> GetAllAboutsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAboutAsync(UpdateAboutDto AboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
