using DapperProject.Dtos.ToDoListDtos;

namespace DapperProject.Services.ToDoListServices
{
    public interface IToDoListService
    {
        Task<List<ResultToDoListDto>> GetResultToDoListAsync();

        Task CreateToDo(string Description);

        Task UpdateToDo(string Description);

        Task ChangeTodoListStatusAsync(int id);

        Task RemoveTodoListAsync(int id);
    }
}
