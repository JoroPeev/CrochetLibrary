using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrochetLibrary.Models
{
    public class Review : IValidatableObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$", ErrorMessage = "Name can only contain letters, spaces, hyphens, or apostrophes.")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required]
        [Range(0, 5)]
        public double? CustomerRating { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
        [Display(Name = "Your Review")]
        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
        public Guid ToyId { get; set; }
        public virtual Toy Toy { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var badWords = new List<string>
            {
                "inappropriate","offensive","hate","stupid","idiot","dumb","terrible","awful","horrible","rude","trash","garbage","spam","scam","fraud","damn","crap","suck","lame","pathetic"
            };

            if (badWords.Any(word => Comment.Contains(word, StringComparison.OrdinalIgnoreCase)))
            {
                yield return new ValidationResult("Comment contains inappropriate words.", new[] { nameof(Comment) });
            }
        }
    }
}