using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Models.VehicleTypeType))]
        public Guid VehicleTypeTypeId { get; set; }
        public VehicleTypeType VehicleTypeType { get; set; }

        public ICollection<Edition> Editions { get; set; } = new HashSet<Edition>();

    }
}
