using System.ComponentModel.DataAnnotations;

namespace CrochetLibrary.Models
{
    public class Toy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 10000)]
        public double Price { get; set; }

        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Yarn { get; set; } = string.Empty;

        [Range(0, 50)]
        public int Hook { get; set; }
    }

}
