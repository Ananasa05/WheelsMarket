using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Brands.ViewModel
{
    public class EditBrandViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Моля, въведете само букви на латиница и интервали")]
        public string Name { get; set; }
    }
}
