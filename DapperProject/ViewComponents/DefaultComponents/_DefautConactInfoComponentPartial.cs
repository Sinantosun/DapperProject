using DapperProject.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefautConactInfoComponentPartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DefautConactInfoComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactService.GetAllContactsAsync();
            return View(values);
        }


    }
}
