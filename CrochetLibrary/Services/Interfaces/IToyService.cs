using CrochetLibrary.Models;

namespace CrochetLibrary.Services
{
    public interface IToyService
    {
        Task<List<Toy>> GetToysAsync();
        Task<List<Toy>> GetToysWithAllImagesAsync();
        Task<Toy?> GetToyByIdAsync(Guid id);
        Task<Toy?> GetToyByIdBasicAsync(Guid id);
        Task<Toy> AddToyAsync(Toy toy);
        Task<Toy> AddToyWithImagesAsync(Toy toy, List<string> imageUrls);
        Task<bool> AddImagesToToyAsync(Guid toyId, List<string> imageUrls);
        Task<bool> UpdateToyAsync(Guid id, Toy toy);
        Task<bool> UpdateToyWithImagesAsync(Guid id, Toy toy, List<string>? newImageUrls = null);
        Task<bool> DeleteToyAsync(Guid id);
        Task<bool> SetPrimaryImageAsync(Guid toyId, Guid imageId);
        Task<bool> DeleteImageAsync(Guid imageId);
        Task<bool> UpdateImageOrderAsync(Guid toyId, List<Guid> imageIdsInOrder);
        Task<List<ToyImage>> GetToyImagesAsync(Guid toyId);
        Task<List<Toy>> SearchToysAsync(string searchTerm);
        Task<List<Toy>> GetToysInStockAsync();
        Task<object> GetToyStatisticsAsync();
    }
}
