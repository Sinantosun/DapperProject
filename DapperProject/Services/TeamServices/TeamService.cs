using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.TeamDtos;

namespace DapperProject.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private readonly DapperContext _context;

        public TeamService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateTeamAsync(CreateTeamDto TeamDto)
        {
            var query = "insert into teams (NameSurname,Title,LinkedinURL,InstagramURL,ImageUrl) values (@NameSurname,@Title,@LinkedinURL,@InstagramURL,@ImageUrl )";
            var parametres = new DynamicParameters(TeamDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task DeleteTeamAsync(int id)
        {
            var query = "delete from teams where TeamId =@TeamId";
            var parametres = new DynamicParameters();
            parametres.Add("@TeamId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }

        public async Task<List<ResultTeamDto>> GetAllTeamsAsync()
        {
            var query = "select * from teams";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultTeamDto>(query);
            return values.ToList();
        }

        public async Task<ResultTeamByIdDto> GetTeamByIdAsync(int id)
        {
            var query = "select * from teams where TeamId = @TeamId";
            var parametres = new DynamicParameters();
            parametres.Add("@TeamId", id); 
            var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultTeamByIdDto>(query,parametres);
        

        }

        public async Task UpdateTeamAsync(UpdateTeamDto TeamDto)
        {
            var query = "update teams set NameSurname = @NameSurname,Title =@Title,LinkedinURL = @LinkedinURL,InstagramURL = @InstagramURL,ImageUrl=@ImageUrl where TeamId = @TeamId";
            var parametres = new DynamicParameters(TeamDto);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parametres);
        }
    }
}
