using System.ComponentModel.DataAnnotations;

namespace WheelsMarket.Data.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Edition> Editions { get; set; } = new HashSet<Edition>();

    }
}
