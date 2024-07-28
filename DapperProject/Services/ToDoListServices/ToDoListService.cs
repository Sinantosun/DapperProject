using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.ToDoListDtos;

namespace DapperProject.Services.ToDoListServices
{
    public class ToDoListService : IToDoListService
    {
        private readonly DapperContext _dapperContext;

        public ToDoListService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task ChangeTodoListStatusAsync(int id)
        {
            var query = "update ToDoList set Status = @Status where ToDoListId = @ToDoListId ";
            var paramtres = new DynamicParameters();
            paramtres.Add("@ToDoListId", id);
            paramtres.Add("@Status", true);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, paramtres);    

        }

        public async Task CreateToDo(string Description)
        {
            var query = "insert into ToDoList (Description,Status) values (@Description,@Status)";
            var parametres = new DynamicParameters();
            parametres.Add("@Description", Description);
            parametres.Add("@Status", false);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);   
        }

        public async Task<ResultToDoListByIdDto> GetById(int id)
        {
            var query = "select * from ToDoList where ToDoListId = @ToDoListId";
            var parametres = new DynamicParameters();
            parametres.Add("@ToDoListId", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultToDoListByIdDto>(query, parametres);
        }

        public async Task<List<ResultToDoListDto>> GetResultToDoListAsync()
        {
            var query = "select * from ToDoList";
            var connection = _dapperContext.CreateConnection();
            var result = await connection.QueryAsync<ResultToDoListDto>(query);
            return result.ToList();
        }

        public async Task RemoveTodoListAsync(int id)
        {
            var query = "delete from ToDoList where ToDoListId = @ToDoListId";
            var parametres = new DynamicParameters();
            parametres.Add("@ToDoListId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query,parametres);
        }

        public async Task UpdateToDo(UpdateToDoListDto updateToDoListDto)
        {
            var query = "update ToDoList set Description  = @Description , Status = @Status where ToDoListId = @ToDoListId";
            var parametres = new DynamicParameters(updateToDoListDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);

        }
    }
}
