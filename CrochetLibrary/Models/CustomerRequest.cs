using System.ComponentModel.DataAnnotations;

public class CustomerRequest
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string ToyName { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    [Required]
    public DateTime DueDate { get; set; }
    public bool SubscribeToNewsletter { get; set; }

}
