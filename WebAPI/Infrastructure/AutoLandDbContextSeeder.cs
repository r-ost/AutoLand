using System;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Infrastructure
{
    public class AutoLandDbContextSeeder
    {
        private readonly AutoLandDbContext _context;
        public AutoLandDbContextSeeder(AutoLandDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (_context.Database.CanConnect())
                if (!_context.Vehicles.Any())
                {
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Audi",
                        ModelName = "A4",
                        Year = 2006,
                        EnginePower = 80,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of Audi A4.",
                        VehicleId = (Guid.NewGuid()).ToString()
                    }
                     );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Audi",
                        ModelName = "A3",
                        Year = 2001,
                        EnginePower = 180,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of Audi A3.",
                        VehicleId = (Guid.NewGuid()).ToString()
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Audi",
                        ModelName = "R8",
                        Year = 2016,
                        EnginePower = 280,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of Audi R8.",
                        VehicleId = (Guid.NewGuid()).ToString()
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Alfa Romeo",
                        ModelName = "Giulietta",
                        Year = 1982,
                        EnginePower = 40,
                        EnginePowerType = "HP",
                        Capacity = 4,
                        Description = "Description of Alfa Romeo Giulietta.",
                        VehicleId = (Guid.NewGuid()).ToString()
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Alfa Romeo",
                        ModelName = "Stelvio",
                        Year = 2016,
                        EnginePower = 80,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of Alfa Romeo Stelvio",
                        VehicleId = (Guid.NewGuid()).ToString()
                    }
                      );
                    _context.SaveChanges();
                }

            if (!_context.PriceEstimations.Any())
            {
                var vehicleId = _context.Vehicles.First().VehicleId;
                _context.PriceEstimations.Add(new PriceEstimation()
                {
                    Price = 200.200,
                    Currency = "zuoto",
                    GeneratedAt = System.DateTime.Now,
                    ExpiredAt = System.DateTime.Now.AddYears(1),
                    QuotaId = Guid.NewGuid(),
                    VehicleId = 1,
                    estimatedVehicle = _context.Vehicles.FirstOrDefault(x => x.Id == 1)
                });
                _context.SaveChanges();
            }
            if (!_context.Rents.Any())
            {

            }
        }
    }
}
