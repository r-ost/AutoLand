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

        public RentResponseDto Rent(string quoteId, StartDateDto startDateDto)
        {
            //todo check if vehicle is available
            var priceEstimations = _context.PriceEstimations.ToList();

            PriceEstimation quotedPE = priceEstimations.FirstOrDefault(x => x.QuotaId == quoteId);
            Rent rent;
            _context.Rents.Add(rent = new Rent //todo powinno byc automaperrowane
            {
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
            //    new RentResponseDto()
            //{
            //    QuoteId = rent.QuoteId,
            //    RentId = rent.RentId,
            //    RentAt = rent.RentAt,
            //    StartDate = rent.StartDate,
            //    EndDate = rent.EndDate
            //};
        }

    }
}
