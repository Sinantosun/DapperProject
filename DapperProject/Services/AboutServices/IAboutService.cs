using DapperProject.Dtos.AboutDtos;

namespace DapperProject.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutsAsync();
        Task<ResultAboutByIdDto> GetAboutByIdAsync(int id);
        Task DeleteAboutAsync(int id);
        Task UpdateAboutAsync(UpdateAboutDto AboutDto);
        Task CreateAboutAsync(CreateAboutDto AboutDto);
    }
}
