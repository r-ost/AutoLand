using System;

namespace WebAPI
{
    public class PriceInfoDto
    {
        public double Price { get; set; }
        public string  Currency { get; set; }
        public DateTime GeneratedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public int QuotaId { get; set; }
    }
}
