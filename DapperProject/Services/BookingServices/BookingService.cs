using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.BookingDtos;

namespace DapperProject.Services.BookingServices
{
    public class BookingService : IBookingService
    {
        private readonly DapperContext _dapperContext;

        public BookingService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateBookingAsync(CreateBookingDto BookingDto)
        {
            var query = "insert into Reservations (Name,Email,Phone,Date,PersonCount,MessageContent) values (@Name,@Email,@Phone,@Date,@PersonCount,@MessageContent)";

            var parametres = new DynamicParameters(BookingDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);


        }

        public async Task DeleteBookingAsync(int id)
        {
            var query = "delete from Reservations where ReservationId  = @ReservationId";
            var parametres = new DynamicParameters();
            parametres.Add("@ReservationId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultBookingDto>> GetAllBookingsAsync()
        {
            var query = "select * from Reservations";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultBookingDto>(query);
            return values.ToList();
        }

        public async Task<ResultBookingByIdDto> GetBookingByIdAsync(int id)
        {
            var query = "select * from Reservations where ReservationId = @ReservationId";
            var parametres = new DynamicParameters();
            parametres.Add("@ReservationId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultBookingByIdDto>(query, parametres);

        }

        public async Task<List<ResultBookingDto>> GetFiveReseravationListAsync()
        {
            var query = "select top 5  * from Reservations order by ReservationId desc";
            var conneciton = _dapperContext.CreateConnection();
            var result = await conneciton.QueryAsync<ResultBookingDto>(query);
            return result.ToList();
        }

        public async Task UpdateBookingAsync(UpdateBookingDto BookingDto)
        {
            var query = "update Reservations set Name = @Name,Email = @Email,Phone = @Phone,Date = @Date,PersonCount = @PersonCount,MessageContent = @MessageContent where ReservationId = @ReservationId";

            var parametres = new DynamicParameters(BookingDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
