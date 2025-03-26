using System.ComponentModel.DataAnnotations;

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

    [MaxLength(500)]
    public string ImageUrl { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Colors { get; set; } = "Red, Blue, Green";

    [Range(0, 1000)]
    public int Stock { get; set; }

}
