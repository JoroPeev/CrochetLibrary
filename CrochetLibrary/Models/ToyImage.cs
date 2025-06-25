using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrochetLibrary.Models
{
    public class ToyImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(500)]
        public string ImageUrl { get; set; } = string.Empty;

        [Range(0, 100)]
        public int DisplayOrder { get; set; } = 0;

        [Required]
        public Guid ToyId { get; set; }

        [ForeignKey("ToyId")]
        public virtual Toy? Toy { get; set; }
    }
}
