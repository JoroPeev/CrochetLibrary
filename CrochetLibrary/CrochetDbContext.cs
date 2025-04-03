using CrochetLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
namespace CrochetLibrary.Data;

public class CrochetDbContext : IdentityDbContext<IdentityUser>
{
    public CrochetDbContext(DbContextOptions<CrochetDbContext> options) : base(options) { }

    public DbSet<Toy> Toys { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .ConfigureWarnings(warnings => warnings
                .Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Toy>()
            .Property(t => t.Price)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Toy>().HasData(
            new Toy
            {
                Id = 1,
                Name = "Classic Teddy Bear",
                Description = "Soft and cuddly hand-crocheted teddy bear with embroidered details. Perfect for snuggling and as a cherished keepsake.",
                Price = 24.99,
                ImageUrl = "https://example.com/classic-teddy-bear.jpg",
                Colors = "Brown, Beige, Cream",
                Stock = 20
            },
            new Toy
            {
                Id = 2,
                Name = "Amigurumi Bunny",
                Description = "Adorable crochet bunny with long floppy ears and a sweet embroidered face. Comes with removable dress.",
                Price = 29.50,
                ImageUrl = "https://example.com/amigurumi-bunny.jpg",
                Colors = "White, Pink, Lavender",
                Stock = 15
            },
            new Toy
            {
                Id = 3,
                Name = "Dinosaur Plushie",
                Description = "Playful crochet dinosaur in vibrant colors. A perfect companion for young adventurers and dinosaur enthusiasts.",
                Price = 26.75,
                ImageUrl = "https://example.com/dinosaur-plushie.jpg",
                Colors = "Green, Blue, Orange",
                Stock = 18
            },
            new Toy
            {
                Id = 4,
                Name = "Rainbow Unicorn",
                Description = "Magical hand-crocheted unicorn with a shimmering mane and tail. Brings imagination and wonder to playtime.",
                Price = 34.99,
                ImageUrl = "https://example.com/rainbow-unicorn.jpg",
                Colors = "White, Rainbow",
                Stock = 12
            },
            new Toy
            {
                Id = 5,
                Name = "Octopus Cuddle Buddy",
                Description = "Soft, huggable octopus with multiple legs in gradient colors. Great for sensory play and comfort.",
                Price = 22.50,
                ImageUrl = "https://example.com/octopus-buddy.jpg",
                Colors = "Blue, Teal, Purple",
                Stock = 25
            }
        );
    }
}