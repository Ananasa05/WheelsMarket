using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Brands.ViewModel
{
    public class AddBrandViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
