using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        
        public string? Color { get; set; } = null;
        public string? Distance { get; set; } = null;
        public string? Fuel { get; set; } = null;
        public string? Condition { get; set; } = null;

        [ForeignKey(nameof(Models.VehicleTypeType))]
        public Guid? VehicleTypeTypeId { get; set; } = null;
        public VehicleTypeType? VehicleTypeType { get; set; } = null;

        [ForeignKey(nameof(Models.Edition))]
        public Guid? EditionId { get; set; } = null;
        public Edition? Edition { get; set; } = null;

        [ForeignKey(nameof(Models.User))]
        public Guid? UserId { get; set; } = null;
        public User? User { get; set; } = null;

        public List<Favourite> FavouritesBy { get; set; } = new List<Favourite>();
    }
}
