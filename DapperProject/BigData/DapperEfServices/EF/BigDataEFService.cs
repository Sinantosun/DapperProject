using DapperProject.BigData.Dtos.EFDtos;
using DapperProject.Context;
using Microsoft.EntityFrameworkCore;

namespace DapperProject.BigData.DapperEfServices.EF
{
    public class BigDataEFService : IBigDataEFService
    {
        private readonly BigDataEFContext _context;

        public BigDataEFService(BigDataEFContext context)
        {
            _context = context;
        }

        public async Task<List<ResultBigDataEFDto>> GetDataWithUsingEFAsync()
        {
            var values = await _context.Sales.AsNoTracking().ToListAsync();
            return values.Select(x => new ResultBigDataEFDto
            {
                CITY = x.CITY,
                ID = x.ID,
                ITEMNAME = x.ITEMNAME,
                NAMESURNAME = x.NAMESURNAME,
                TOTALPRICE = x.TOTALPRICE,
                TOWN = x.TOWN,
                USERNAME_ = x.USERNAME_

            }).ToList();


        }
    }
}
