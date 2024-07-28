using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.TestimonailDtos;

namespace DapperProject.Services.TestimonailServices
{
    public class TestimonailService : ITestimonialService
    {
        private readonly DapperContext _dapperContext;

        public TestimonailService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateTestimonialAsync(CreateTestimonialDto TestimonialDto)
        {
            var query = "insert into Testimonials (ImageUrl,NameSurname,Location,Comment) values (@ImageUrl,@NameSurname,@Location,@Comment)";
            var parametres = new DynamicParameters(TestimonialDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteTestimonialAsync(int id)
        {
            var query = "delete from Testimonials where TestimonialId=@TestimonialId";
            var parametres = new DynamicParameters();
            parametres.Add("@TestimonialId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync()
        {
            var query = "select * from Testimonials";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultTestimonialDto>(query);
            return values.ToList();
        }

        public async Task<ResultTestimonialByIdDto> GetTestimonialByIdAsync(int id)
        {
            var query = "select * from Testimonials where TestimonialId=@TestimonialId";
            var parametres = new DynamicParameters();
            parametres.Add("@TestimonialId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultTestimonialByIdDto>(query, parametres);

        }

        public async Task UpdateTestimonialAsync(UpdateTestimonialDto TestimonialDto)
        {
            var query = "update Testimonials set ImageUrl = @ImageUrl,NameSurname=@NameSurname,Location=@Location,Comment=@Comment where TestimonialId=@TestimonialId";
            var parametres = new DynamicParameters(TestimonialDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
