using DapperProject.Dtos.CategoryDtos;

namespace DapperProject.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task<List<ResultCategoryByIdDto>> GetCategoryByIdAsync(int id);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);

    }
}
