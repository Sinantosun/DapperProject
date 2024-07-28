using DapperProject.Dtos.EventDtos;
using DapperProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllEventsAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventDto createEventDto)
        {
            await _eventService.CreateEventAsync(createEventDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEvent(int id)
        {
            var result = await _eventService.GetEventByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEvent(UpdateEventDto updateEventDto)
        {
            await _eventService.UpdateEventAsync(updateEventDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return RedirectToAction("Index");
        }
    }
}
