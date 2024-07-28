using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.MessageDtos;

namespace DapperProject.Services.MessageServices
{
    public class MessageService : IMessageService
    {
        private readonly DapperContext _dapperContext;

        public MessageService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateMessageAsync(CreateMessageDto MessageDto)
        {
            var query = "insert into Messages (NameSurname,Email,Title,MessageContent) values (@NameSurname,@Email,@Title,@MessageContent)";
            var parametres = new DynamicParameters(MessageDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);   
        }

        public async Task DeleteMessageAsync(int id)
        {
            var query = "delete from Messages where MessageId = @MessageId";
            var parametres = new DynamicParameters();
            parametres.Add("@MessageId", id);
            var connection = _dapperContext.CreateConnection(); 
            await connection.ExecuteAsync(query,parametres);
        }

        public async Task<List<ResultMessageDto>> GetAllMessagesAsync()
        {
            var query = "select * from Messages";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultMessageDto>(query);
            return values.ToList();
        }

        public async Task<ResultMessageByIdDto> GetMessageByIdAsync(int id)
        {
            var query = "select * from Messages where MessageId = @MessageId";
            var parametres = new DynamicParameters();
            parametres.Add("@MessageId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultMessageByIdDto>(query,parametres);
            
        }

        public async Task UpdateMessageAsync(UpdateMessageDto MessageDto)
        {
            var query = "Update Messages set NameSurname = @NameSurname,Email = @Email,Title = @Title,MessageContent = @MessageContent where MessageId = @MessageId ";
            var parametres = new DynamicParameters(MessageDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
