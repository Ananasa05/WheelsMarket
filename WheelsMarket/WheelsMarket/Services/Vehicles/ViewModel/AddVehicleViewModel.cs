using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class AddVehicleViewModel
    {
        [Required(ErrorMessage = "Цветът е задължителен.")]
      
        public string Color { get; set; }

        [Required(ErrorMessage = "Разстоянието е задължително.")]
        public int Distance { get; set; }

        [Required(ErrorMessage = "Горивото е задължително.")]
       
        public string Fuel { get; set; }

        [Required(ErrorMessage = "Състоянието е задължително.")]
        
        public string Condition { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Цената е задължителна.")]
        [Range(0, 500000, ErrorMessage = "Цената трябва да бъде между 0 и 200 000.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Обемът е задължителен.")]
        [Range(0, 20000, ErrorMessage = "Цената трябва да бъде между 0 и 20 000.")]

        public int Volume { get; set; }
        [Required(ErrorMessage = "Годината е задължителна.")]

        public int Year { get; set; }

        [Required(ErrorMessage = "Скоростната кутия е задължителна.")]
        public string Тransmission { get; set; }

        [Required(ErrorMessage = "Евро стандартът е задължителен.")]
        public string EuroStandart { get; set; }

        //[Required(ErrorMessage = "VIN номерът е задължителен.")]
        //[Range(17, 17, ErrorMessage = "Цената трябва да бъде 17 символа.")]

        public int VinNumber { get; set; }

        [Required(ErrorMessage = "Мощността в конски сили е задължителна.")]
        [Range(0, 2000, ErrorMessage = "Цената трябва да бъде между 0 и 2000.")]
        public int HoursePower { get; set; }

        [Required(ErrorMessage = "Областта на местоположението е задължителна.")]
        [StringLength(50, ErrorMessage = "Областта на местоположението трябва да бъде между 1 и 50 символа.", MinimumLength = 1)]
        public string LocationRegion { get; set; }

        [Required(ErrorMessage = "Градът на местоположението е задължителен.")]
        [StringLength(50, ErrorMessage = "Градът на местоположението трябва да бъде между 1 и 50 символа.", MinimumLength = 1)]
        public string LocationTown { get; set; }

        [StringLength(500, ErrorMessage = "Допълнителната информация не може да бъде повече от 500 символа.")]
        public string MoreInformation { get; set; }

        [Required(ErrorMessage = "Валутата е задължителна.")]
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
