using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
	public class BrandFilterViewModel
	{
		[ValidateNever]
		public Guid EditionId { get; set; }
		[ValidateNever]
		public Guid BrandId { get; set; }
		[ValidateNever]
		public Guid VehicleTypeTypeId { get; set; }
		[ValidateNever]
		public Guid VehicleTypeSectionId { get; set; }
	}
}
