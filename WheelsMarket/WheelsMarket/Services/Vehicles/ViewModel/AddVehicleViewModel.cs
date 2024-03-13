using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AddVehicleViewModel
    {
        [Required]
        public string Color { get; set; }
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
