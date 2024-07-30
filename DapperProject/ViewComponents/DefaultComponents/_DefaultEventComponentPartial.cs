using DapperProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DefaultComponents
{
    public class _DefaultEventComponentPartial : ViewComponent
    {
        private readonly IEventService _eventService;

        public _DefaultEventComponentPartial(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _eventService.GetAllEventsAsync();
            return View(values);
        }
    }
}
