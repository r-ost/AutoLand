﻿using System;
namespace WebAPI.Entities
{
    public enum RentStatus
    {
        Pending = 0,
        CarRentedToCustomer = 1,
        Completed = 2
    }
    public class Rent
    {
        public int Id { get; set; }
        public string RentId { get; set; } = "";

        public DateTime? RentAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public RentStatus RentStatus { get; set; }


        public int VehicleId { get; set; }
        public Vehicle vehicle { get; set; }


        public int PriceId { get; set; }
        public PriceEstimation priceEstimation { get; set; }


        public string QuotaId { get; set; } = "";

    }
}
