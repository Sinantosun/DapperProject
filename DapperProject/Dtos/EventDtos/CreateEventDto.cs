namespace DapperProject.Dtos.EventDtos
{
    public class CreateEventDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string TopDescription { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string BottomDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
