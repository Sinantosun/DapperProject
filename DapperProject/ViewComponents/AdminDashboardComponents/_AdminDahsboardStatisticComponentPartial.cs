using DapperProject.Services.DashboardServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.AdminDashboardComponents
{
    public class _AdminDahsboardStatisticComponentPartial : ViewComponent
    {
        private readonly IDashboardService _dashboardService;

        public _AdminDahsboardStatisticComponentPartial(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _dashboardService.GetResultDashboardStatisticDto();
            return View(value);
        }
    }
}
