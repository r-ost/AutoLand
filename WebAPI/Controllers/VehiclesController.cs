using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
namespace WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : Controller
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IVehicleService _vehicleService;

        public VehiclesController(ILogger<VehiclesController> logger, IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VehicleDto>> Get()
        {
            return StatusCode(200, _vehicleService.Get());
        }

        [HttpPost("Rent/{quoteId}")]
        public RentResponseDto Rent([FromRoute] int quoteId, [FromBody] StartDateDto startDateDto)
        {
            throw new NotImplementedException();
        }
    }


}
