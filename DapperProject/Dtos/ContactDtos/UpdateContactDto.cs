namespace DapperProject.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string Location { get; set; }
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
