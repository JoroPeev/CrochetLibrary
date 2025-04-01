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
            return await _context.Toys.ToListAsync();
        }

        public async Task<Toy?> GetByIdAsync(int id)
        {
            return await _context.Toys.FindAsync(id);
        }

        public async Task<Toy> AddAsync(Toy toy)
        {
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

        public async Task<bool> DeleteAsync(int id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null) return false;

            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
