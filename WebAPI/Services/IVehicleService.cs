using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;

namespace WebAPI
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDto> Get();
    }
}

