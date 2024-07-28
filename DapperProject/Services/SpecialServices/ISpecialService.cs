using DapperProject.Dtos.SpecialDtos;

namespace DapperProject.Services.SpecialServices
{
    public interface ISpecialService
    {
        Task<List<ResultSpecialDto>> GetAllSpecialsAsync();
        Task<ResultSpecialByIdDto> GetSpecialByIdAsync(int id);
        Task DeleteSpecialAsync(int id);
        Task UpdateSpecialAsync(UpdateSpecialDto SpecialDto);
        Task CreateSpecialAsync(CreateSpecialDto SpecialDto);
    }
}
