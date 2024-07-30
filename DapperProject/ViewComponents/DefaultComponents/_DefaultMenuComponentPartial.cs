using DapperProject.Services.CategoryServices;
using DapperProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultMenuComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public _DefaultMenuComponentPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = values;
            var products = await _productService.GetAllProductAsync();
            return View(products);
        }

    }
}
