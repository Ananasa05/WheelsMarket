using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string Color { get; set; }
        [Required]
        public string Distance { get; set; }
        [Required]
        public string Fuel { get; set; }
        [Required]
        public string Condition { get; set; }

        [ForeignKey(nameof(Models.VehicleTypeType))]
        public Guid VehicleTypeTypeId { get; set; }
        public VehicleTypeType VehicleTypeType { get; set; }

        [ForeignKey(nameof(Models.Edition))]
        public Guid EditionId { get; set; }
        public Edition Edition { get; set; }

        [ForeignKey(nameof(Models.User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<Favourite> FavouritesBy { get; set; } = new List<Favourite>();
    }
}
