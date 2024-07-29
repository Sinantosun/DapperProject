using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
