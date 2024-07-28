using DapperProject.Dtos.TeamDtos;

namespace DapperProject.Services.TeamServices
{
    public interface ITeamService
    {
        Task<List<ResultTeamDto>> GetAllTeamsAsync();
        Task<ResultTeamByIdDto> GetTeamByIdAsync(int id);
        Task DeleteTeamAsync(int id);
        Task UpdateTeamAsync(UpdateTeamDto TeamDto);
        Task CreateTeamAsync(CreateTeamDto TeamDto);
    }
}
