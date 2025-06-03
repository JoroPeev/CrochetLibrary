using CrochetLibrary.Data;
using CrochetLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Repositories
{
    public class ToyRepository : IToyRepository
    {
        private readonly CrochetDbContext _context;

        public ToyRepository(CrochetDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Toy>> GetAllAsync()
        {
            return await _context.Toys
                .Include(t => t.Images.OrderBy(i => i.DisplayOrder))
                .ToListAsync();
        }

        public async Task<Toy?> GetByIdAsync(Guid id)
        {
            return await _context.Toys
                .Include(t => t.Images.OrderBy(i => i.DisplayOrder))
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Toy> AddAsync(Toy toy)
        {
            toy.Id = Guid.NewGuid();
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();
            return toy;
        }

        public async Task<bool> UpdateAsync(Toy toy)
        {
            _context.Entry(toy).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null) return false;

            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Toys.AnyAsync(t => t.Id == id);
        }
    }
}
