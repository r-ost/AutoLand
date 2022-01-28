using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Entities;
using WebAPI.Infrastructure;
using AutoMapper;

namespace WebAPI.Services
{
    public class RentService : IRentService
    {
        private AutoLandDbContext _context;
        private IMapper _mapper;
        public RentService(AutoLandDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public RentResponseDto Rent(Guid quoteId, StartDateDto startDateDto)
        {
            //todo check if vehicle is available

            PriceEstimation quotedPE = _context.PriceEstimations.FirstOrDefault(x => x.QuotaId == quoteId);
            Rent rent;
            _context.Rents.Add(rent = new Rent //todo powinno byc automaperrowane
            {
                RentId = Guid.NewGuid(),
                RentAt = DateTime.Now,
                StartDate = startDateDto.StartDate,
                //EndDate = //from where?
                RentStatus = RentStatus.Pending,
                PriceId = quotedPE.Id,
                priceEstimation = quotedPE,
                QuoteId = Guid.NewGuid()
            });
            _context.SaveChanges();

            return _mapper.Map<RentResponseDto>(rent);
        }

        public void Return(Guid rentId)
        {
            //todo add biznes logic
            Rent rent = _context.Rents.FirstOrDefault(r => r.RentId == rentId);
            if(rent != null)
            {
                rent.RentStatus = RentStatus.Completed;
                rent.EndDate = DateTime.Now;
                _context.Rents.Update(rent);
                _context.SaveChanges();
            }
        }
    }
}
