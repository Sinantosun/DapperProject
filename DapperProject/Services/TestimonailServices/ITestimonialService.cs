using DapperProject.Dtos.TestimonailDtos;

namespace DapperProject.Services.TestimonailServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync();
        Task<ResultTestimonialByIdDto> GetTestimonialByIdAsync(int id);
        Task DeleteTestimonialAsync(int id);
        Task UpdateTestimonialAsync(UpdateTestimonialDto TestimonialDto);
        Task CreateTestimonialAsync(CreateTestimonialDto TestimonialDto);
    }
}
