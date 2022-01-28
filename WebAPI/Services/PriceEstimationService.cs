using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Infrastructure;

namespace WebAPI.Services
{
    public class PriceEstimationService : IPriceEstimationService
    {
        private AutoLandDbContext _context;
        private IMapper _mapper;
        public PriceEstimationService(AutoLandDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtostring, string brand, string model)
        {
            throw new System.NotImplementedException();
        }

        public PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtoint, int id)
        {
            throw new System.NotImplementedException();
        }
    
    }
}
