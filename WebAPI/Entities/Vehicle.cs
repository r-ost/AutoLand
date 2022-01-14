namespace WebAPI.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public int Year { get; set; }

        public int EnginePower { get; set; }

        public string EnginePowerType { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; }
    }
}
