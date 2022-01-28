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
            if (_context.Database.CanConnect())
                if (!_context.Vehicles.Any())
                {
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Toyota",
                        ModelName = "Corolla",
                        Year = 2006,
                        EnginePower = 80,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of Toyota Corolla: very reliable and slow."
                    }
                     );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Volvo",
                        ModelName = "S60",
                        Year = 2001,
                        EnginePower = 180,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of TVolvo: old and fast."
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Volvo",
                        ModelName = "XC60",
                        Year = 2016,
                        EnginePower = 280,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of better volvo: 4x4 and spacey."
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Fiat",
                        ModelName = "500",
                        Year = 1982,
                        EnginePower = 40,
                        EnginePowerType = "HP",
                        Capacity = 4,
                        Description = "Description of better cinquecento: old but gold."
                    }
                      );
                    _context.Vehicles.Add(new Vehicle
                    {
                        BrandName = "Hyundai",
                        ModelName = "i20",
                        Year = 2016,
                        EnginePower = 80,
                        EnginePowerType = "HP",
                        Capacity = 5,
                        Description = "Description of better Hyundai: small and steady"
                    }
                      );
                    _context.SaveChanges();
                }

            if (!_context.PriceEstimations.Any())
            {
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
