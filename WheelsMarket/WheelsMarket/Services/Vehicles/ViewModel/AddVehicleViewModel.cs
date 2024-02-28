namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AddVehicleViewModel
    {
        public string Color { get; set; }
        public string Distance { get; set; }
        public string Fuel { get; set; }
        public string Condition { get; set; }
        public Guid VehicleTypeTypeId { get; set; }
        public Guid EditionId { get; set; }
        public Guid UserId { get; set; }
    }
}
