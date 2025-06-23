using CrochetLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Data;

public class CrochetDbContext : IdentityDbContext<IdentityUser>
{
    public CrochetDbContext(DbContextOptions<CrochetDbContext> options) : base(options) { }

    public DbSet<Toy> Toys { get; set; }
    public DbSet<ToyImage> ToyImages { get; set; }
    public DbSet<CustomerRequest> Requests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Toy>()
            .Property(t => t.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<ToyImage>()
                .HasOne(ti => ti.Toy)
                .WithMany(t => t.Images)
                .HasForeignKey(ti => ti.ToyId)
                .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ToyImage>()
            .HasIndex(ti => new { ti.ToyId, ti.IsPrimary })
            .HasFilter("[IsPrimary] = 1")
            .IsUnique();

        modelBuilder.Entity<ToyImage>()
            .HasIndex(ti => new { ti.ToyId, ti.DisplayOrder });

        var toy1Id = Guid.NewGuid();
        var toy2Id = Guid.NewGuid();
        var toy3Id = Guid.NewGuid();
        var toy4Id = Guid.NewGuid();
        var toy5Id = Guid.NewGuid();

        modelBuilder.Entity<Toy>().HasData(
            new Toy { Id = toy1Id, Name = "Classic Teddy Bear", Description = "Soft and cuddly hand-crocheted teddy bear...", Price = 24.99, Colors = "Brown, Beige, Cream", Stock = 20 },
            new Toy { Id = toy2Id, Name = "Amigurumi Bunny", Description = "Adorable crochet bunny...", Price = 29.50, Colors = "White, Pink, Lavender", Stock = 15 },
            new Toy { Id = toy3Id, Name = "Dinosaur Plushie", Description = "Playful crochet dinosaur...", Price = 26.75, Colors = "Green, Blue, Orange", Stock = 18 },
            new Toy { Id = toy4Id, Name = "Rainbow Unicorn", Description = "Magical hand-crocheted unicorn...", Price = 34.99, Colors = "White, Rainbow", Stock = 12 },
            new Toy { Id = toy5Id, Name = "Octopus Cuddle Buddy", Description = "Soft, huggable octopus...", Price = 22.50, Colors = "Blue, Teal, Purple", Stock = 25 }
        );

        // Seed ToyImages
        modelBuilder.Entity<ToyImage>().HasData(
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://example.com/teddy-bear-1.jpg", AltText = "Classic Teddy Bear - Front View", DisplayOrder = 1, IsPrimary = true },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://example.com/teddy-bear-2.jpg", AltText = "Classic Teddy Bear - Side View", DisplayOrder = 2, IsPrimary = false },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://example.com/teddy-bear-3.jpg", AltText = "Classic Teddy Bear - Back View", DisplayOrder = 3, IsPrimary = false },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://example.com/bunny-1.jpg", AltText = "Amigurumi Bunny - With Dress", DisplayOrder = 1, IsPrimary = true },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://example.com/bunny-2.jpg", AltText = "Amigurumi Bunny - Without Dress", DisplayOrder = 2, IsPrimary = false },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://example.com/bunny-3.jpg", AltText = "Amigurumi Bunny - Close-up Face", DisplayOrder = 3, IsPrimary = false },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://example.com/dinosaur-1.jpg", AltText = "Dinosaur Plushie - Green Version", DisplayOrder = 1, IsPrimary = true },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://example.com/dinosaur-2.jpg", AltText = "Dinosaur Plushie - Blue Version", DisplayOrder = 2, IsPrimary = false },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://example.com/dinosaur-3.jpg", AltText = "Dinosaur Plushie - Orange Version", DisplayOrder = 3, IsPrimary = false },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://example.com/unicorn-1.jpg", AltText = "Rainbow Unicorn - Full Body", DisplayOrder = 1, IsPrimary = true },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://example.com/unicorn-2.jpg", AltText = "Rainbow Unicorn - Mane Detail", DisplayOrder = 2, IsPrimary = false },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://example.com/unicorn-3.jpg", AltText = "Rainbow Unicorn - Horn Close-up", DisplayOrder = 3, IsPrimary = false },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://example.com/octopus-1.jpg", AltText = "Octopus Cuddle Buddy - Full View", DisplayOrder = 1, IsPrimary = true },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://example.com/octopus-2.jpg", AltText = "Octopus Cuddle Buddy - Tentacles Detail", DisplayOrder = 2, IsPrimary = false },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://example.com/octopus-3.jpg", AltText = "Octopus Cuddle Buddy - Face Close-up", DisplayOrder = 3, IsPrimary = false }
        );
    }
}
