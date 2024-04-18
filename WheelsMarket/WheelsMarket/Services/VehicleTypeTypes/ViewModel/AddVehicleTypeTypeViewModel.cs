using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.VehicleTypeTypes.ViewModel
{
    public class AddVehicleTypeTypeViewModel
    {
        [Required]
        [RegularExpression(@"^[а-яА-Я\s]*$", ErrorMessage = "Моля, въведете само букви на кирилица и интервали")]
        public string Type { get; set; }
        [Required]
        public Guid VehicleTypeSectionId { get; set; }
    }
}
