using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class VehicleTypeType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

        [ForeignKey(nameof(Models.VehicleTypeSection))]
        public Guid VehicleTypeSectionId { get; set; }
        public VehicleTypeSection VehicleTypeSection { get; set; }
    }
}
