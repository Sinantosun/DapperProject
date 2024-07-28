using DapperProject.Dtos.TeamDtos;
using DapperProject.Services.TeamServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _teamService.GetAllTeamsAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDto createTeamDto)
        {
            await _teamService.CreateTeamAsync(createTeamDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var result = await _teamService.GetTeamByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeam(UpdateTeamDto updateTeamDto)
        {
            await _teamService.UpdateTeamAsync(updateTeamDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteTeamAsync(id);
            return RedirectToAction("Index");
        }
    }
}
