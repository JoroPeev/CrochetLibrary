using System.ComponentModel.DataAnnotations;

namespace CrochetLibrary.Models
{
    public class CustomerRequest
    {
        public int Id { get; set; }

        [Required]
        public int ToyId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        [Required]
        public DateTime DueDate { get; set; }
    }
}
