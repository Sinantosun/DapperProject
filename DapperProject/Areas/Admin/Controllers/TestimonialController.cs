using DapperProject.Dtos.TestimonailDtos;
using DapperProject.Services.TestimonailServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TestimonailController : Controller
    {
        private readonly ITestimonialService _testimonailService;

        public TestimonailController(ITestimonialService TestimonailService)
        {
            _testimonailService = TestimonailService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _testimonailService.GetAllTestimonialsAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonail(CreateTestimonialDto createTestimonailDto)
        {
            await _testimonailService.CreateTestimonialAsync(createTestimonailDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonail(int id)
        {
            var result = await _testimonailService.GetTestimonialByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonail(UpdateTestimonialDto updateTestimonailDto)
        {
            await _testimonailService.UpdateTestimonialAsync(updateTestimonailDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteTestimonail(int id)
        {
            await _testimonailService.DeleteTestimonialAsync(id);
            return RedirectToAction("Index");
        }
    }
}
