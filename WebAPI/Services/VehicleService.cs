using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Infrastructure;

namespace WebAPI.Services
{
    public class VehicleService : IVehicleService
    {
        private AutoLandDbContext _context;
        private IMapper _mapper;
        public VehicleService(AutoLandDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<VehicleDto> GetAll()
        {
            var vehicles = _context.Vehicles.ToList();

            return _mapper.Map<List<VehicleDto>>(vehicles);

        }
    }
}
