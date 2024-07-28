using DapperProject.Dtos.DashboardDtos;

namespace DapperProject.Services.DashboardServices
{
    public interface IDashboardService
    {
        Task<ResultDashboardStatisticDto> GetResultDashboardStatisticDto();
    }
}
