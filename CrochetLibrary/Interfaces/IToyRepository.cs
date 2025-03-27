namespace CrochetLibrary.Repositories
{
    public interface IToyRepository
    {
        Task<IEnumerable<Toy>> GetAllAsync();
        Task<Toy?> GetByIdAsync(int id);
        Task<Toy> AddAsync(Toy toy);
        Task<bool> UpdateAsync(Toy toy);
        Task<bool> DeleteAsync(int id);
    }
}
