using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
