using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
