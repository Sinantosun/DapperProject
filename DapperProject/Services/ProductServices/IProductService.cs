using DapperProject.Dtos.ProductDtos;

namespace DapperProject.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<ResultProductByIdDto> GetProductByIdAsync(int id);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(UpdateProductDto ProductDto);
        Task CreateProductAsync(CreateProductDto ProductDto);



    }
}
