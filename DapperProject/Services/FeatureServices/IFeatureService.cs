using DapperProject.Dtos.FeatureDtos;

namespace DapperProject.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatrueDto>> GetAllFeaturesAsync();
        Task<ResultFeatureByIdDto> GetFeatureByIdAsync(int id);
        Task DeleteFeatureAsync(int id);
        Task UpdateFeatureAsync(UpdateFeatureDto FeatureDto);
        Task CreateFeatureAsync(CreateFeatureDto FeatureDto);
    }
}
