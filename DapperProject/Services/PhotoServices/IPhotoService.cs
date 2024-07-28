using DapperProject.Dtos.PhotoDtos;

namespace DapperProject.Services.PhotoServices
{
    public interface IPhotoService
    {
        Task<List<ResultPhotoDto>> GetAllPhotosAsync();
        Task<ResultPhotoByIdDto> GetPhotoByIdAsync(int id);
        Task DeletePhotoAsync(int id);
        Task UpdatePhotoAsync(UpdatePhotoDto PhotoDto);
        Task CreatePhotoAsync(CreatePhotoDto PhotoDto);
    }
}
