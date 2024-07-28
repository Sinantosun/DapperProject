namespace DapperProject.Dtos.ToDoListDtos
{
    public class UpdateToDoListDto
    {
        public int ToDoListId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
