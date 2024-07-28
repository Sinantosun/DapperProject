using DapperProject.Dtos.BookingDtos;


namespace DapperProject.Services.BookingServices
{
    public interface IBookingService
    {
        Task<List<ResultBookingDto>> GetAllBookingsAsync();
        Task<ResultBookingByIdDto> GetBookingByIdAsync(int id);
        Task DeleteBookingAsync(int id);
        Task UpdateBookingAsync(UpdateBookingDto BookingDto);
        Task CreateBookingAsync(CreateBookingDto BookingDto);

        Task<List<ResultBookingDto>> GetFiveReseravationListAsync();
    }
}
