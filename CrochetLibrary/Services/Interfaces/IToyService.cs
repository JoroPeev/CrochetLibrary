using CrochetLibrary.Models;

namespace CrochetLibrary.Services
{
    public interface IToyService
    {
        Task<List<Toy>> GetToysAsync();
        Task<Toy?> GetToyByIdAsync(Guid id);
        Task<Toy> AddToyAsync(Toy toy);
        Task<bool> AddImagesToToyAsync(Guid toyId, List<string> imageUrls);
        Task<bool> UpdateToyAsync(Guid id, Toy toy);
        Task<bool> DeleteToyAsync(Guid id);
        Task<bool> DeleteImageAsync(Guid imageId);
        Task<List<ToyImage>> GetToyImagesAsync(Guid toyId);
        Task<bool> UpdateImageAsync(Guid imageId, string newImageUrl, int? newDisplayOrder = null);
    }
}
