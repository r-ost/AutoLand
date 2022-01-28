using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Services;

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
        public ActionResult<PriceResponseInfoDto> GetPrice(string brand, string model, [FromBody] UserRentInfoDto userRentInfoDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/GetPrice")]
        public ActionResult<PriceResponseInfoDto> GetPrice(int id, [FromBody] UserRentInfoDto userRentInfoDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Return/{rentId}")]
        public ActionResult Return(int rentId)
        {
            throw new NotImplementedException();
        }
    }
}
