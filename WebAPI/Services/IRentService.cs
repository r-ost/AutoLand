
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
namespace WebAPI.Services
{
    public interface IRentService
    {
        RentResponseDto Rent(string quoteId, StartDateDto startDateDto);
        void Return(Guid guid);
    }
}
