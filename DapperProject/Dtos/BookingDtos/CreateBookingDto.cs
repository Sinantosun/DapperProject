namespace DapperProject.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public int PersonCount { get; set; }
        public string MessageContent { get; set; }
    }
}
