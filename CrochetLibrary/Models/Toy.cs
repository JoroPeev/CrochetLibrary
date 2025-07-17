using CrochetLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Toy
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 10000)]
    public double Price { get; set; }

    [MaxLength(200)]
    public string Colors { get; set; } = "Red, Blue, Green";

    [Range(0, 1000)]
    public int Stock { get; set; }

    [Range(0, 1000)]
    public int CraftingTimeInDays { get; set; }

    [Range(0, 5)]
    public double? CustomerRating { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual ICollection<ToyImage> Images { get; set; } = new List<ToyImage>();

    [NotMapped]
    public List<string> ImageUrls => Images?.OrderBy(i => i.DisplayOrder).Select(i => i.ImageUrl).ToList()
                                   ?? new List<string>();
}