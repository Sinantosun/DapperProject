using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
