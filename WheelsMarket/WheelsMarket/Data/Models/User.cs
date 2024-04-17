using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.SecurityStamp = Guid.NewGuid().ToString("D");
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Favourite> Favourites { get; set; } = new List<Favourite>();

    }
}
