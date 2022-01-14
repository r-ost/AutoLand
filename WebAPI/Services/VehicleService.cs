using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos

namespace WebAPI
{
    public class VehicleService : IVehicleService
    {
        public IEnumerable<VehicleDto> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new VehicleDto
            {
                BrandName = "Mercedes",
                ModelName = "AMG",
                Year = rng.Next(2000, 2010),
                EnginePower = rng.Next(200, 400),
                EnginePowerType = "KM",
                Capacity = rng.Next(3, 5),
                Description = "--przyładowy opis" + index + "--"
            })
            .ToArray();
        }
    }
}
