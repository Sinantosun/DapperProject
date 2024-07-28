using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.EventDtos;

namespace DapperProject.Services.EventServices
{
    public class EventService : IEventService
    {
        private readonly DapperContext _context;

        public EventService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateEventAsync(CreateEventDto EventDto)
        {
            var query = "insert into Events (Title,Price,TopDescription,Property1,Property2,Property3,BottomDescription,ImageUrl) values (@Title,@Price,@TopDescription,@Property1,@Property2,@Property3,@BottomDescription,@ImageUrl)";

            var parametres = new DynamicParameters(EventDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteEventAsync(int id)
        {
            var query = "delete from Events where EventId = @EventId";
            var parametres = new DynamicParameters();
            parametres.Add("@EventId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }

        public async Task<List<ResultEventDto>> GetAllEventsAsync()
        {
            var query = "select * from Events";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultEventDto>(query);
            return values.ToList();

        }

        public async Task<ResultEventByIdDto> GetEventByIdAsync(int id)
        {
            var query = "select * from Events where EventId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultEventByIdDto>(query, parametres);

        }

        public async Task UpdateEventAsync(UpdateEventDto EventDto)
        {
            var query = "update Events set Title = @Title,Price = @Price,TopDescription = @TopDescription,Property1 = @Property1,Property2 = @Property2,Property3 = @Property3,BottomDescription = @BottomDescription,ImageUrl= @ImageUrl where EventId = @EventId";
            var parametres = new DynamicParameters(EventDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
