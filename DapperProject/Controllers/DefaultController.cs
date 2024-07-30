using DapperProject.Dtos.BookingDtos;
using DapperProject.Dtos.MessageDtos;
using DapperProject.Services.BookingServices;
using DapperProject.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IBookingService _bookingService;
        public DefaultController(IMessageService messageService, IBookingService bookingService)
        {
            _messageService = messageService;
            _bookingService = bookingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            await _messageService.CreateMessageAsync(createMessageDto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            await _bookingService.CreateBookingAsync(createBookingDto);
            return RedirectToAction("Index");
        }
    }
}
