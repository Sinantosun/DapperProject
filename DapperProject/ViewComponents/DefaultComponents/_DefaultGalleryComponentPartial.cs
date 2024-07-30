using DapperProject.Services.PhotoServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultGalleryComponentPartial : ViewComponent
    {
        private readonly IPhotoService _photoService;

        public _DefaultGalleryComponentPartial(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _photoService.GetAllPhotosAsync();
            return View(values);
        }
    }
}
