using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Services;
namespace WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : Controller
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IVehicleService _vehicleService;
        private readonly IRentService _rentService;

        public VehiclesController(ILogger<VehiclesController> logger, IVehicleService vehicleService, IRentService rentService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
            _rentService = rentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VehicleDto>> Get()
        {
            return StatusCode(200, _vehicleService.GetAll());
        }

        [HttpPost("Rent/{quoteId}")]
        public ActionResult<RentResponseDto> Rent([FromRoute] string quoteId/*or quotA?*/, [FromBody] StartDateDto startDateDto)
        {
            
            return StatusCode(201, _rentService.Rent(quoteId, startDateDto));
        }
    }


}
