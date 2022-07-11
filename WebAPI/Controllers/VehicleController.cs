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
        private readonly IPriceEstimationService _priceEstimationService;
        private readonly IRentService _rentService;

        public VehicleController(ILogger<VehicleController> logger, IPriceEstimationService priceEstimationService, IRentService rentService)
        {
            _logger = logger;
            _priceEstimationService = priceEstimationService;
            _rentService = rentService;
        }


        [HttpPost("{brand}/{model}/GetPrice")]
        public ActionResult<PriceResponseInfoDto> GetPrice([FromBody] UserRentInfoDto userRentInfoDto, string brand, string model)
        {
            return StatusCode(200, _priceEstimationService.GetPrice(userRentInfoDto, brand, model));
        }

        [HttpPost("{id}/GetPrice")]
        public ActionResult<PriceResponseInfoDto> GetPrice([FromBody] UserRentInfoDto userRentInfoDto, Guid id)
        {
            return StatusCode(200, _priceEstimationService.GetPrice(userRentInfoDto, id.ToString()));
        }

        [HttpPost("Return/{rentId}")]
        public ActionResult Return(Guid rentId)
        {
            _rentService.Return(rentId);
            return StatusCode(200);
        }
    }
}
