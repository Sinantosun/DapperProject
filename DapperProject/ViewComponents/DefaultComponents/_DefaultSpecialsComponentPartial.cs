using DapperProject.Services.SpecialServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultSpecialsComponentPartial : ViewComponent
    {
        private readonly ISpecialService _specialService;

        public _DefaultSpecialsComponentPartial(ISpecialService specialService)
        {
            _specialService = specialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _specialService.GetAllSpecialsAsync();

            return View(values);
        }
    }
}
