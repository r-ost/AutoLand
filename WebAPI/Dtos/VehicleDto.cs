using System;

namespace WebAPI.Dtos
{
    public class VehicleDto
    {
        public string BrandName { get; init; }

        public string ModelName { get; init; }

        public int Year { get; init; }

        public int EnginePower { get; init; }

        public string EnginePowerType { get; init; }

        public int Capacity { get; init; }

        public string Description { get; init; }
    }
}
