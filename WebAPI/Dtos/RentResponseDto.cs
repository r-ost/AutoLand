using System;
namespace WebAPI.Dtos
{
    public class RentResponseDto
    {
        public string QuoteId { get; init; }
        public string RentId { get; init; }
        public DateTime RentAt { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime endDate { get; init; }
    }
}
