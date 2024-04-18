using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class ByPriceFilterViewModel
    {
        [Range(1, 500000, ErrorMessage = "Цената трябва да е между 1 и 500 000.")]
        public string min { get; set; }
        [Range(1, 500000, ErrorMessage = "Цената трябва да е между 1 и 500 000.")]

        public int max { get; set; }
    }
}
