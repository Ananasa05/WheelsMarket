using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Editions.ViewModel
{
    public class EditEditionViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Моля, въведете само букви на латиница и интервали")]
        public string Name { get; set; }
    }
}
