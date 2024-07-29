using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.UILayoutComponents
{
    public class _UILayoutTopBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
