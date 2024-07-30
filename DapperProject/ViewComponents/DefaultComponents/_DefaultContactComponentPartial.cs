using DapperProject.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
   

      
        public async Task<IViewComponentResult> InvokeAsync()
        {
          
            return View();
        }

    }
}
