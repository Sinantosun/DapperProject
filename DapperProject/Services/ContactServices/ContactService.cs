using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.ContactDtos;

namespace DapperProject.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly DapperContext _dapperContext;

        public ContactService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateContactAsync(CreateContactDto ContactDto)
        {
            var query = "insert into Contacts (Location,OpenHours,Email,PhoneNumber) values (@Location,@OpenHours,@Email,@PhoneNumber)";
            var parametres = new DynamicParameters(ContactDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteContactAsync(int id)
        {
            var query = "delete from contacts where ContactId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultContactDto>> GetAllContactsAsync()
        {
            var query = "select * from contacts";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultContactDto>(query);
            return values.ToList();
        }

        public async Task<ResultContactByIdDto> GetContactByIdAsync(int id)
        {
            var query = "select * from contacts where ContactId = @id";
            var parametres = new DynamicParameters();
            parametres.Add("@id", id);
            var connection = _dapperContext.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultContactByIdDto>(query, parametres);
        }

        public async Task UpdateContactAsync(UpdateContactDto ContactDto)
        {
            var query = "update Contacts set Location = @Location,OpenHours = @OpenHours,Email = @Email,PhoneNumber = @PhoneNumber where ContactId = @ContactId";
            var parametres = new DynamicParameters(ContactDto);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
