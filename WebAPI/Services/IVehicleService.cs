using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;

namespace WebAPI.Services
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDto> GetAll();
    }
}

