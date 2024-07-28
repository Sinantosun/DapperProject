using DapperProject.Services.BookingServices;
using DapperProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardReseravtionComponentPartial : ViewComponent
    {
       private readonly IBookingService _bookingService;

        public _AdminDashboardReseravtionComponentPartial(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bookingService.GetFiveReseravationListAsync();
            return View(values);
        }
    }
}
