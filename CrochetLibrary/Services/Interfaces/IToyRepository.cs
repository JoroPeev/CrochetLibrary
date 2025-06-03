namespace CrochetLibrary.Services.Interfaces
{
    public interface IToyRepository
    {
        Task<IEnumerable<Toy>> GetAllAsync();
        Task<Toy?> GetByIdAsync(Guid id);
        Task<Toy> AddAsync(Toy toy);
        Task<bool> UpdateAsync(Toy toy);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
