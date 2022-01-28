using System;
namespace WebAPI.Dtos
{
    public class RentResponseDto
    {
        public Guid QuoteId { get; init; }
        public Guid RentId { get; init; }
        public DateTime RentAt { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; init; }
    }
}
