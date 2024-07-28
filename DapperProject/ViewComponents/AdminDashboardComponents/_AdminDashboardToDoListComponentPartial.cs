using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardToDoListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
