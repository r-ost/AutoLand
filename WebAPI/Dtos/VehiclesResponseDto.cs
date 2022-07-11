using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos
{
    public class VehiclesResponseDto
    {
        public IEnumerable<VehicleDto> Vehicles{get; set;}
        public int VehiclesCount { get; set; }
        public DateTime GenerateDate { get; set; }
    }
}