using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.VehicleTypeTypes.ViewModel
{
    public class AddVehicleTypeTypeViewModel
    {
        public string Type { get; set; }
        public Guid VehicleTypeSectionId { get; set; }
    }
}
