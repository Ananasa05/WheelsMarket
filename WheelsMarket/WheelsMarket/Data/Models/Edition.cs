using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class Edition
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(Models.Brand))]
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();


    }
}
