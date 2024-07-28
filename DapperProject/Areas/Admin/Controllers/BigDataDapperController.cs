using DapperProject.BigData.DapperEfServices.Dapper;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BigDataDapperController : Controller
    {
        private readonly IBigDataDapperService _bigDataDapperService;

        public BigDataDapperController(IBigDataDapperService bigDataDapperService)
        {
            _bigDataDapperService = bigDataDapperService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bigDataDapperService.GetDataWithUsingDapperAsync();
            return View(values);
        }
    }
}
