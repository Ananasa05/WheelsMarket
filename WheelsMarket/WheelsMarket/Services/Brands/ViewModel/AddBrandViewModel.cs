using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Brands.ViewModel
{
    public class AddBrandViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Моля, въведете само букви на латиница и интервали")]
        public string Name { get; set; }
        public Guid VehicleTypeTypeId { get; set; }

    }
}
