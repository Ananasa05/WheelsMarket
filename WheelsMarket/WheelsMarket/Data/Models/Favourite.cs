using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class Favourite
    {
        public bool IsFavourite { get; set; }
        [Required]
        public Guid VehicleId { get; set; }
        [Required]
        public Guid UserId { get; set; }//string

        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; }
        [ForeignKey(nameof(UserId))]

        public User User { get; set; }
    }
}
