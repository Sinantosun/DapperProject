using DapperProject.BigData.DapperEfServices.EF;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BigDataEFController : Controller
    {
        private readonly IBigDataEFService _bigDataEFService;

        public BigDataEFController(IBigDataEFService bigDataEFService)
        {
            _bigDataEFService = bigDataEFService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bigDataEFService.GetDataWithUsingEFAsync();

            return View(values);
        }
    }
}
