using CrochetLibrary.Models;

public interface IToyService
{
    Task<IEnumerable<Toy>> GetToysAsync();
    Task<Toy> GetToyByIdAsync(Guid id);
    Task<Toy> AddToyAsync(Toy toy);
    Task<bool> UpdateToyAsync(Guid id, Toy toy);
    Task<bool> DeleteToyAsync(Guid id);
    Task<IEnumerable<ToyImage>> GetToyImagesAsync(Guid id);
    Task<bool> AddImagesToToyAsync(Guid id, List<string> imageUrls);
    Task<bool> UpdateImageAsync(Guid imageId, string imageUrl, int displayOrder);
    Task<bool> AddReviewToToyAsync(Guid id, Review review);
    Task<bool> DeleteReviewAsync(Guid reviewId);
    Task<IEnumerable<Review>> GetToyReviewsAsync(Guid id);
    Task<bool> DeleteImageAsync(Guid imageId);
}