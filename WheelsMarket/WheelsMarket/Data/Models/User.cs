using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Favourite> Favourites { get; set; } = new List<Favourite>();

        //[Required]
        //public string? Name { get; set; }
        //[Required]
        //public string? Email { get; set; }
        //[Required]
        //public string? EIK { get; set; }

    }
}
