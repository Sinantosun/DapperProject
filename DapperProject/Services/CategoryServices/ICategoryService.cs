using DapperProject.Dtos.CategoryDtos;

namespace DapperProject.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task<ResultCategoryByIdDto> GetCategoryByIdAsync(int id);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);

    }
}
