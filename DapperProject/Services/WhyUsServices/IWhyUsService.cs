using DapperProject.Dtos.WhyUsDtos;

namespace DapperProject.Services.WhyUsServices
{
    public interface IWhyUsService
    {
        Task<List<ResultWhyUsDto>> GetAllWhyUsAsync();
        Task<ResultWhyUsByIdDto> GetWhyUsByIdAsync(int id);
        Task DeleteWhyUsAsync(int id);
        Task UpdateWhyUsAsync(UpdateWhyUsDto WhyUsDto);
        Task CreateWhyUsAsync(CreateWhyUsDto WhyUsDto);
    }
}
