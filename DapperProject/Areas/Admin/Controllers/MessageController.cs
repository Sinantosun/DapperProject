using DapperProject.Dtos.MessageDtos;
using DapperProject.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class MessageController : Controller
	{
		private readonly IMessageService _messageService;

		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _messageService.GetAllMessagesAsync();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateMessage()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
		{
			await _messageService.CreateMessageAsync(createMessageDto);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateMessage(int id)
		{
			var result = await _messageService.GetMessageByIdAsync(id);
			return View(result);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			await _messageService.UpdateMessageAsync(updateMessageDto);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> DeleteMessage(int id)
		{
			await _messageService.DeleteMessageAsync(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> MessageDetail(int id)
		{
			var value = await _messageService.GetMessageByIdAsync(id);
			return View(value);
		}

	}
}
