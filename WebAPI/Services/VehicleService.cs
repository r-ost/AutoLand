using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Infrastructure;

namespace WebAPI
{
    public class VehicleService : IVehicleService
    {
        private AutoLandDbContext _context;
        public VehicleService(AutoLandDbContext context)
        {
            _context = context;
        }
        public IEnumerable<VehicleDto> Get()
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

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new VehicleDto
            //{
            //    BrandName = "Mercedes",
            //    ModelName = "AMG",
            //    Year = rng.Next(2000, 2010),
            //    EnginePower = rng.Next(200, 400),
            //    EnginePowerType = "KM",
            //    Capacity = rng.Next(3, 5),
            //    Description = "--przyładowy opis" + index + "--"
            //})
            //.ToArray();
        }
    }
}
