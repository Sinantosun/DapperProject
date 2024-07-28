using DapperProject.Dtos.SpecialDtos;
using DapperProject.Services.SpecialServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class SpecialController : Controller
    {
        private readonly ISpecialService _specialService;

        public SpecialController(ISpecialService specialService)
        {
            _specialService = specialService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _specialService.GetAllSpecialsAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSpecial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSpecial(CreateSpecialDto createSpecialDto)
        {
            await _specialService.CreateSpecialAsync(createSpecialDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSpecial(int id)
        {
            var result = await _specialService.GetSpecialByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSpecial(UpdateSpecialDto updateSpecialDto)
        {
            await _specialService.UpdateSpecialAsync(updateSpecialDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteSpecial(int id)
        {
            await _specialService.DeleteSpecialAsync(id);
            return RedirectToAction("Index");
        }
    }
}
