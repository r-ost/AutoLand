using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleService _vehicleService;

        public VehicleController(ILogger<VehicleController> logger, IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }


        [HttpPost("{brand}/{model}/GetPrice")]
        public double GetPrice(string brand, string model, [FromBody] RentDto rentDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/GetPrice")]
        public double GetPrice(int id, [FromBody] RentDto rentDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Return/{rentId}")]
        public double GetPrice(int rentId)
        {
            throw new NotImplementedException();
        }
    }
}
