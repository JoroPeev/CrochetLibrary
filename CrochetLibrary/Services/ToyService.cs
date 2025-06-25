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

        public async Task<List<Toy>> GetToysAsync()
        {
            return await _context.Toys.ToListAsync();
        }
        public async Task<List<Toy>> GetToysWithAllImagesAsync()
        {
            return await _context.Toys
                .Include(t => t.Images.OrderBy(i => i.DisplayOrder))
                .ToListAsync();
        }

        public async Task<Toy?> GetToyByIdAsync(Guid id)
        {
            return await _context.Toys.FirstOrDefaultAsync(t => t.Id == id);
        }


        public async Task<Toy?> GetToyByIdBasicAsync(Guid id)
        {
            return await _context.Toys.FindAsync(id);
        }

        public async Task<Toy> AddToyAsync(Toy toy)
        {
            toy.Id = Guid.NewGuid();
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();
            return toy;
        }

        public async Task<Toy> AddToyWithImagesAsync(Toy toy, List<string> imageUrls)
        {
            toy.Id = Guid.NewGuid();
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();

            if (imageUrls is { Count: > 0 })
            {
                await AddImagesToToyAsync(toy.Id, imageUrls);
            }

            return toy;
        }

        public async Task<bool> AddImagesToToyAsync(Guid toyId, List<string> imageUrls)
        {
            if (!await ToyExistsAsync(toyId) || imageUrls is null or { Count: 0 })
                return false;

            var existingImagesCount = await _context.ToyImages
                .CountAsync(ti => ti.ToyId == toyId);

            var images = imageUrls.Select((url, index) => new ToyImage
            {
                Id = Guid.NewGuid(),
                ToyId = toyId,
                ImageUrl = url,
                DisplayOrder = existingImagesCount + index + 1,
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

        public async Task<bool> UpdateToyWithImagesAsync(Guid id, Toy toy, List<string>? newImageUrls = null)
        {
            if (id != toy.Id)
                return false;

            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                _context.Entry(toy).State = EntityState.Modified;

                if (newImageUrls is { Count: > 0 })
                {
                    var existingImages = await _context.ToyImages
                        .Where(ti => ti.ToyId == id)
                        .ToListAsync();

                    _context.ToyImages.RemoveRange(existingImages);

                    var images = newImageUrls.Select((url, index) => new ToyImage
                    {
                        Id = Guid.NewGuid(),
                        ToyId = id,
                        ImageUrl = url,
                        DisplayOrder = index + 1,
                    }).ToList();

                    _context.ToyImages.AddRange(images);
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                await transaction.RollbackAsync();
                if (!await ToyExistsAsync(id))
                    return false;

                throw;
            }
            catch
            {
                await transaction.RollbackAsync();
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

        public async Task<bool> SetPrimaryImageAsync(Guid toyId, Guid imageId)
        {
            var allImages = await _context.ToyImages
                .Where(ti => ti.ToyId == toyId)
                .ToListAsync();

            if (!allImages.Any(i => i.Id == imageId))
                return false;


            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteImageAsync(Guid imageId)
        {
            var image = await _context.ToyImages.FindAsync(imageId);
            if (image is null)
                return false;

            var nextImage = await _context.ToyImages
                .Where(ti => ti.ToyId == image.ToyId && ti.Id != imageId)
                .OrderBy(ti => ti.DisplayOrder)
                .FirstOrDefaultAsync();

            _context.ToyImages.Remove(image);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateImageOrderAsync(Guid toyId, List<Guid> imageIdsInOrder)
        {
            var images = await _context.ToyImages
                .Where(ti => ti.ToyId == toyId)
                .ToListAsync();

            for (int i = 0; i < imageIdsInOrder.Count; i++)
            {
                var image = images.FirstOrDefault(img => img.Id == imageIdsInOrder[i]);
                if (image is not null)
                {
                    image.DisplayOrder = i + 1;
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<ToyImage>> GetToyImagesAsync(Guid toyId)
        {
            return await _context.ToyImages
                .Where(ti => ti.ToyId == toyId)
                .OrderBy(ti => ti.DisplayOrder)
                .ToListAsync();
        }

        public async Task<List<Toy>> SearchToysAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetToysAsync();

            return await _context.Toys
                .Include(t => t.Images.Take(1))
                .Where(t => t.Name.Contains(searchTerm) || t.Description.Contains(searchTerm))
                .ToListAsync();
        }

        private async Task<bool> ToyExistsAsync(Guid id)
        {
            return await _context.Toys.AnyAsync(e => e.Id == id);
        }

        public async Task<object> GetToyStatisticsAsync()
        {
            return new
            {
                TotalToys = await _context.Toys.CountAsync(),
                ToysInStock = await _context.Toys.CountAsync(t => t.Stock > 0),
                ToysOutOfStock = await _context.Toys.CountAsync(t => t.Stock == 0),
                AveragePrice = await _context.Toys.AverageAsync(t => t.Price),
                TotalImages = await _context.ToyImages.CountAsync()
            };
        }
    }
}
