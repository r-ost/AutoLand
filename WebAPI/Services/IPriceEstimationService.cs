using WebAPI.Dtos;

namespace WebAPI.Services
{
    public interface IPriceEstimationService
    {
        PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtostring, string brand, string model);
        PriceResponseInfoDto GetPrice(UserRentInfoDto userRentInfoDtoint, int id);
    }
}
