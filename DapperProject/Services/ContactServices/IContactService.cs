using DapperProject.Dtos.ContactDtos;

namespace DapperProject.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllContactsAsync();
        Task<ResultContactByIdDto> GetContactByIdAsync(int id);
        Task DeleteContactAsync(int id);
        Task UpdateContactAsync(UpdateContactDto ContactDto);
        Task CreateContactAsync(CreateContactDto ContactDto);
    }
}
