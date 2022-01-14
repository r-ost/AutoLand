using System;
namespace WebAPI.Dtos
{
    public class RentResponseDto
    {
        public int QuoteId { get; set; }
        public int RentId { get; set; }
        public DateTime RentAt { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
