using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Infrastructure;

namespace WebAPI.Services
{
    public class VehicleService : IVehicleService
    {
        private AutoLandDbContext _context;
        public VehicleService(AutoLandDbContext context)
        {
            _context = context;
        }
        public IEnumerable<VehicleDto> GetAll()
        {
            var vehicles = _context.Vehicles.ToList();

            return vehicles.Select(x => new VehicleDto()
            {
                BrandName = x.BrandName,
                Capacity = x.Capacity,
                Description = x.Description,
                EnginePower = x.EnginePower,
                EnginePowerType = x.EnginePowerType,
                ModelName = x.ModelName,
                Year = x.Year
            });

        }
    }
}
