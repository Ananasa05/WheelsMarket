using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AddVehicleViewModel
    {
        public string Color { get; set; }
        public int Distance { get; set; }
        public string Fuel { get; set; }
        public string Condition { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }
        [Range(0, 200)]
        public int Price { get; set; }
        public int Volume { get; set; }
        public int Year { get; set; }
        public string Тransmission { get; set; }
		public string EuroStandart { get; set; }
		public int VinNumber { get; set; }
		public int HoursePower { get; set; }
		public string LocationRegion { get; set; }
		public string LocationTown { get; set; }
        public string MoreInformation { get; set; }
        public string Currency { get; set; }
        public bool IsApproved { get; set; }
        public Guid UserId { get; set; }
        [ValidateNever]
        public Guid EditionId { get; set; }
        [ValidateNever]
        public Guid BrandId { get; set; }
        [ValidateNever]
        public Guid VehicleTypeTypeId{ get; set; }
        [ValidateNever]
        public Guid VehicleTypeSectionId { get; set; }
    }
}
