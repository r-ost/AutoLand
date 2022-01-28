using System;

namespace WebAPI.Entities
{
    public class PriceEstimation
    {
        public int Id { get; set; }

        public double Price { get; set; }
        public string Currency { get; set; } = "";
        public DateTime GeneratedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public string QuotaId { get; set; } = "";


        public int VehicleId { get; set; }
        public Vehicle vehicle { get; set; }

        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
