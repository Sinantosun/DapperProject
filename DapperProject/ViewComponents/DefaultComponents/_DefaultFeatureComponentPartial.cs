using DapperProject.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _DefaultFeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllFeaturesAsync();
            return View(values);
        }
    }
}
