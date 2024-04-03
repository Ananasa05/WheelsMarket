using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class Favourite
    {
        [ForeignKey(nameof(Vehicle))]
		public Guid? VehicleId { get; set; }
		public Vehicle? Vehicle { get; set; }

        [ForeignKey(nameof(User))]
		public Guid? UserId { get; set; }
		public User? User { get; set; }
    }
}
