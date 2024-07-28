using DapperProject.BigData.Dtos.DapperDtos;
using DapperProject.BigData.Dtos.EFDtos;

namespace DapperProject.BigData.DapperEfServices.EF
{
    public interface IBigDataEFService
    {
        Task<List<ResultBigDataEFDto>> GetDataWithUsingEFAsync();
    }
}
