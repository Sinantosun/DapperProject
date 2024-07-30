using DapperProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAboutsAsync();
            return View(values);
        }
    }
}
