using DapperProject.Services.WhyUsServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultWhyUsComponentPartial : ViewComponent
    {
        private readonly IWhyUsService _whyUsService;

        public _DefaultWhyUsComponentPartial(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _whyUsService.GetAllWhyUsAsync();
            return View(values);
        }
    }
}
