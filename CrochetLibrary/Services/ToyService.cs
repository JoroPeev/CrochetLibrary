using CrochetLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Services
{
    public class ToyService
    {
        private readonly CrochetDbContext _context;

        public ToyService(CrochetDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Toy>> GetToysAsync()
        {
            return await _context.Toys.ToListAsync();
        }

        public async Task<Toy?> GetToyByIdAsync(int id)
        {
            return await _context.Toys.FindAsync(id);
        }

        public async Task<Toy> AddToyAsync(Toy toy)
        {
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();
            return toy;
        }

        public async Task<bool> UpdateToyAsync(int id, Toy toy)
        {
            if (id != toy.Id)
                return false;

            _context.Entry(toy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ToyExistsAsync(id))
                    return false;
                else
                    throw;
            }
        }

        public async Task<bool> DeleteToyAsync(int id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null)
                return false;

            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();
            return true;
        }

        private async Task<bool> ToyExistsAsync(int id)
        {
            return await _context.Toys.AnyAsync(e => e.Id == id);
        }
    }
}
