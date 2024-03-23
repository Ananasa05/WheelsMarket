using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AddVehicleViewModel
    {
        [Required]
        public string Color { get; set; }
        [Required]
        public int Distance { get; set; }
        [Required]
        public string Fuel { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Volume { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Тransmission { get; set; }
        [Required]

		public Guid EditionId { get; set; }
		[Required]

		public Guid BrandId { get; set; }
        [Required]

        public Guid VehicleTypeTypeId{ get; set; }
        [Required]

        public Guid VehicleTypeSectionId { get; set; }
    }
}
