using DapperProject.Dtos.ToDoListDtos;
using DapperProject.Services.ToDoListServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class DashBoardController : Controller
    {
        private readonly IToDoListService _toDoListService;

        public DashBoardController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TodoList()
        {
            var values = await _toDoListService.GetResultToDoListAsync();
            var JsonData = JsonConvert.SerializeObject(values);
            return Json(JsonData);
        }
        [HttpPost]
        public async Task<IActionResult> AddToDo(string description)
        {
            await _toDoListService.CreateToDo(description);
            return Json("success");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeToDoListStatus(int id)
        {
            await _toDoListService.ChangeTodoListStatusAsync(id);
            return Json("success");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveToDoList(int id)
        {
            await _toDoListService.RemoveTodoListAsync(id);
            return Json("success");
        }

        public async Task<IActionResult> GetByIdResult(int id)
        {
            var value = await _toDoListService.GetById(id);
            var JsonData = JsonConvert.SerializeObject(value);
            return Json(JsonData);

        }

        public async Task<IActionResult> UpdateToDo(UpdateToDoListDto updateToDoListDto)
        {
            await _toDoListService.UpdateToDo(updateToDoListDto);
            return Json("success");

        }
    }


}
