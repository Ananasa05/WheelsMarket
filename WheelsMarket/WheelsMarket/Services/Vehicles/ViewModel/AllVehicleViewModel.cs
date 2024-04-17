using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AllVehicleViewModel
    {
		public Guid? Id { get; set; }
		public string? Color { get; set; }
		public int? Distance { get; set; }
		public string? Fuel { get; set; }
		public string? Condition { get; set; }
		public string? ImageURL { get; set; }
		public int? Price { get; set; }
		public int? Volume { get; set; }
		public int? Year { get; set; }
		public string? Тransmission { get; set; }
		public string? EuroStandart { get; set; }
		public int? VinNumber { get; set; }
		public int? HoursePower { get; set; }
        public string? LocationRegion { get; set; }
        public string? LocationTown { get; set; }
        public string? MoreInformation { get; set; }
		public string? Currency { get; set; }
		public string? EditionName { get; set; }
        public string? BrandName { get; set; }
		public string? TypeType { get; set; }
		public string? TypeSection { get; set; }
		public bool? IsApproved { get; set; }
		public string? UserFirstName { get; set; }
		public string? UserLastName { get; set; }
	}
}
