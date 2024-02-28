using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.VehicleTypeSections.ViewModel
{
    public class AddVehicleTypeSectionViewModel
    {
        [Required]
        public string Section { get; set; }
    }
}
