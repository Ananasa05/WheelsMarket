using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.VehicleTypeTypes.ViewModel
{
    public class EditVehicleTypeTypeViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[а-яА-Я\s]*$", ErrorMessage = "Моля, въведете само букви на кирилица и интервали")]
        public string Type { get; set; }
    }
}
