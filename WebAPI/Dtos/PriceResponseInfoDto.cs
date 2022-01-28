using System;

namespace WebAPI.Dtos
{
    public class PriceResponseInfoDto
    {
        public double Price { get; init; }
        public string  Currency { get; init; }
        public DateTime GeneratedAt { get; init; }
        public DateTime ExpiredAt { get; init; }
        public Guid QuotaId { get; init; }
    }
}
