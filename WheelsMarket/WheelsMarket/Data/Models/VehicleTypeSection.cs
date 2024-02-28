using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class VehicleTypeSection
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Section { get; set; }
        public ICollection<VehicleTypeType> VehicleTypeType { get; set; } = null!;
    }
}
