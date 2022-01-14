namespace WebAPI
{
    public class RentInfoDto
    {
        public int Age { get; init; }
        public int YearsOfHavingDriverLicense { get; init; }
        public int RentDuration { get; init; }
        public string Location { get; init; }
        public int CurrentlyRentedCount { get; init; }
        public int OverallRentedCount { get; init; }
    }
}
