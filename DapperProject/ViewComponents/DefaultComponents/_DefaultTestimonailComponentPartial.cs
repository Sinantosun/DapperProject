using DapperProject.Services.TestimonailServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonailComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonailComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllTestimonialsAsync();
            return View(values);
        }

    }
}
