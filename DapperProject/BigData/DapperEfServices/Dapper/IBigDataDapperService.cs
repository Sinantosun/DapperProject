﻿using DapperProject.BigData.Dtos.DapperDtos;

namespace DapperProject.BigData.DapperEfServices.Dapper
{
    public interface IBigDataDapperService
    {
        Task<List<ResultBigDataDto>> GetDataWithUsingDapperAsync();
    }
}