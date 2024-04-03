using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelsMarket.Data.Models
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        public string? Тransmission { get; set; } = null;
        public int? Volume { get; set; } = null;
        public int? Price { get; set; } = null;
        public string? Color { get; set; } = null;
        public int? Distance { get; set; } = null;
        public string? Fuel { get; set; } = null;
        public string? Condition { get; set; } = null;
        public int? Year { get; set; } = null;
        public string? EuroStandard { get; set; } = null;
        public int? VinNumber { get; set; } = null;
        public string? Currency { get; set; } = null;
        public int? HoursePower { get; set; } = null;
        public string? LocationRegion { get; set; } = null;
        public string? LocationTown { get; set; } = null;
        public string? ImageURL { get; set; } = null;
        public string? MoreInformation { get; set; } = null;


        [ForeignKey(nameof(Models.Edition))]
        public Guid? EditionId { get; set; } = null;
        public Edition? Edition { get; set; } = null;

        [ForeignKey(nameof(Models.User))]
        public Guid? UserId { get; set; } = null;
        public User? User { get; set; } = null;

        public List<Favourite> FavouritesBy { get; set; } = new List<Favourite>();
    }
}
