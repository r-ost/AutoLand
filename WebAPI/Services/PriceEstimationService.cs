using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Entities;
using WebAPI.Infrastructure;
using AutoMapper;

namespace WebAPI.Services
{
    public class PriceEstimationService : IPriceEstimationService
    {
        private AutoLandDbContext _context;
        private IMapper _mapper;
        public PriceEstimationService(AutoLandDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtostring, string brand, string model)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.ModelName == model && x.BrandName == brand);

            var priceEstimation = new PriceEstimation()
            {
                Currency = "PLN",
                GeneratedAt = DateTime.Now,
                ExpiredAt = DateTime.Now.AddMinutes(15),
                QuotaId = Guid.NewGuid(),
                VehicleId = vehicle.Id,
                estimatedVehicle = vehicle,
                RentDuration = userRentInfoDtostring.RentDuration
            };
            priceEstimation.Calculate();

            _context.PriceEstimations.Add(priceEstimation);
            _context.SaveChanges();

            return _mapper.Map<PriceResponseInfoDto>(priceEstimation);
        }

        public PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtoint, string id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehicleId == id);

            var priceEstimation = new PriceEstimation()
            {
                Currency = "PLN",
                GeneratedAt = DateTime.Now,
                ExpiredAt = DateTime.Now.AddMinutes(15),
                QuotaId = Guid.NewGuid(),
                VehicleId = vehicle.Id,
                estimatedVehicle = vehicle,
                RentDuration = userRentInfoDtoint.RentDuration
            };
            priceEstimation.Calculate();

            _context.PriceEstimations.Add(priceEstimation);
            _context.SaveChanges();

            return _mapper.Map<PriceResponseInfoDto>(priceEstimation);
        }  
    }
}
