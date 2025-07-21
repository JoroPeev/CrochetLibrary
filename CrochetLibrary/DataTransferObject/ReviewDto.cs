using System.ComponentModel.DataAnnotations;

namespace CrochetLibrary.DataTransferObject
{
    public class ReviewDto
    {
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
        [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
        [Display(Name = "Your Review")]
        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
    }
}
