namespace DapperProject.Dtos.CategoryDtos
{
    public class RemoveCategoryDto
    {
        public RemoveCategoryDto(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
