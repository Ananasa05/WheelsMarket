using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Account
{
    public class ApplicationUser
    {
        [StringLength(20)]
        public string? UserName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

        public int Age { get; set; }
    }
}
