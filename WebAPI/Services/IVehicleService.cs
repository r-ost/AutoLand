using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDto> Get();
    }
}

