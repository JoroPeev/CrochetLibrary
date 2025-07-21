using CrochetLibrary.Data;
using CrochetLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Services
{
    public class ToyService : IToyService
    {
        private readonly CrochetDbContext _context;

        public ToyService(CrochetDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Toy>> GetToysAsync()
        {
            return await _context.Toys
                .Include(t => t.Images)
                .Include(t => t.Reviews)
                .ToListAsync();
        }

        public async Task<Toy?> GetToyByIdAsync(Guid id)
        {
            return await _context.Toys
                .Include(t => t.Images)
                .Include(t => t.Reviews)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Review>> GetToyReviewsAsync(Guid toyId)
        {
            return await _context.Reviews
                .Where(r => r.ToyId == toyId)
                .ToListAsync();
        }

        public async Task<Toy> AddToyAsync(Toy toy)
        {
            toy.Id = Guid.NewGuid();
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();
            return toy;
        }

        public async Task<bool> AddImagesToToyAsync(Guid toyId, List<string> imageUrls)
        {
            if (!await ToyExistsAsync(toyId) || imageUrls is null || imageUrls.Count == 0)
                return false;

            var existingImagesCount = await _context.ToyImages
                .CountAsync(ti => ti.ToyId == toyId);

            var images = imageUrls.Select((url, index) => new ToyImage
            {
                Id = Guid.NewGuid(),
                ToyId = toyId,
                ImageUrl = url,
                DisplayOrder = existingImagesCount + index + 1
            }).ToList();

            _context.ToyImages.AddRange(images);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateToyAsync(Guid id, Toy toy)
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

                throw;
            }
        }

        public async Task<bool> DeleteToyAsync(Guid id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy is null)
                return false;

            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ToyImage>> GetToyImagesAsync(Guid toyId)
        {
            return await _context.ToyImages
                .Where(ti => ti.ToyId == toyId)
                .OrderBy(ti => ti.DisplayOrder)
                .ToListAsync();
        }

        public async Task<bool> UpdateImageAsync(Guid imageId, string imageUrl, int displayOrder)
        {
            var image = await _context.ToyImages.FindAsync(imageId);
            if (image is null)
                return false;

            image.ImageUrl = imageUrl;
            image.DisplayOrder = displayOrder;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteImageAsync(Guid imageId)
        {
            var image = await _context.ToyImages.FindAsync(imageId);
            if (image is null)
                return false;

            _context.ToyImages.Remove(image);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddReviewToToyAsync(Guid toyId, Review review)
        {
            if (!await ToyExistsAsync(toyId) || review is null)
                return false;

            review.Id = Guid.NewGuid();
            review.ToyId = toyId;
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteReviewAsync(Guid reviewId)
        {
            var review = await _context.Reviews.FindAsync(reviewId);
            if (review is null)
                return false;

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return true;
        }

        private async Task<bool> ToyExistsAsync(Guid id)
        {
            return await _context.Toys.AnyAsync(e => e.Id == id);
        }
    }
}