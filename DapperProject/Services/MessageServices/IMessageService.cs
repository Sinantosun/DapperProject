using DapperProject.Dtos.MessageDtos;

namespace DapperProject.Services.MessageServices
{
    public interface IMessageService
    {
        Task<List<ResultMessageDto>> GetAllMessagesAsync();
        Task<ResultMessageByIdDto> GetMessageByIdAsync(int id);
        Task DeleteMessageAsync(int id);
        Task UpdateMessageAsync(UpdateMessageDto MessageDto);
        Task CreateMessageAsync(CreateMessageDto MessageDto);
    }
}
