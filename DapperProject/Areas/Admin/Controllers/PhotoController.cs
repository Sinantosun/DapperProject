using DapperProject.Dtos.PhotoDtos;
using DapperProject.Services.PhotoServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _photoService.GetAllPhotosAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePhoto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePhoto(CreatePhotoDto createPhotoDto)
        {
            await _photoService.CreatePhotoAsync(createPhotoDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePhoto(int id)
        {
            var result = await _photoService.GetPhotoByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePhoto(UpdatePhotoDto updatePhotoDto)
        {
            await _photoService.UpdatePhotoAsync(updatePhotoDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeletePhoto(int id)
        {
            await _photoService.DeletePhotoAsync(id);
            return RedirectToAction("Index");
        }
    }
}
