using DapperProject.Dtos.EventDtos;

namespace DapperProject.Services.EventServices
{
    public interface IEventService
    {
        Task<List<ResultEventDto>> GetAllEventsAsync();
        Task<ResultEventByIdDto> GetEventByIdAsync(int id);
        Task DeleteEventAsync(int id);
        Task UpdateEventAsync(UpdateEventDto EventDto);
        Task CreateEventAsync(CreateEventDto EventDto);
    }
}
