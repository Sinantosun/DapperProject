using DapperProject.Dtos.WhyUsDtos;
using DapperProject.Services.WhyUsServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class WhyChooseUsController : Controller
    {
        private readonly IWhyUsService _whyUsService;

        public WhyChooseUsController(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _whyUsService.GetAllWhyUsAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateWhyUs()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhyUs(CreateWhyUsDto createWhyUsDto)
        {
            await _whyUsService.CreateWhyUsAsync(createWhyUsDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWhyUs(int id)
        {
            var result = await _whyUsService.GetWhyUsByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWhyUs(UpdateWhyUsDto updateWhyUsDto)
        {
            await _whyUsService.UpdateWhyUsAsync(updateWhyUsDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteWhyUs(int id)
        {
            await _whyUsService.DeleteWhyUsAsync(id);
            return RedirectToAction("Index");
        }
    }
}
