using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultMenuComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
