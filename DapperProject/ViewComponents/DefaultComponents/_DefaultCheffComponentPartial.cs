using DapperProject.Services.TeamServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultCheffComponentPartial : ViewComponent
    {
      private readonly ITeamService _teamService;

        public _DefaultCheffComponentPartial(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _teamService.GetAllTeamsAsync();
            return View(values);
        }
    }
}
