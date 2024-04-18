using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.VehicleTypeSections.ViewModel
{
    public class AddVehicleTypeSectionViewModel
    {
        [Required]
        [RegularExpression(@"^[а-яА-Я\s]*$", ErrorMessage = "Моля, въведете само букви на кирилица и интервали")]
        public string Section { get; set; }
    }
}
