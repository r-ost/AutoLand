﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
namespace WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IVehicleService _vehicleService;

        public VehiclesController(ILogger<VehiclesController> logger, IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public IEnumerable<VehicleDto> Get()
        {
            return _vehicleService.Get();
        }

        [HttpPost("Rent/{quoteId}")]
        public double GetPrice([FromRoute] int quoteId, [FromBody] StartDateDto startDateDto)
        {
            throw new NotImplementedException();
        }
    }


}