using DapperProject.Dtos.ToDoListDtos;

namespace DapperProject.Services.ToDoListServices
{
    public interface IToDoListService
    {
        Task<List<ResultToDoListDto>> GetResultToDoListAsync();

        Task CreateToDo(string Description);

        Task UpdateToDo(UpdateToDoListDto updateToDoListDto);

        Task ChangeTodoListStatusAsync(int id);

        Task RemoveTodoListAsync(int id);

        Task<ResultToDoListByIdDto> GetById(int id);
    }
}
