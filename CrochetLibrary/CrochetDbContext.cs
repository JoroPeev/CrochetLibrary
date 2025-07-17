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
    public DbSet<Review> Reviews { get; set; }

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
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_0.jpg", DisplayOrder = 1 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/3:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_2.jpg", DisplayOrder = 2 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy1Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_3.jpg", DisplayOrder = 3 },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_3.jpg", DisplayOrder = 1 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/2:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_1.jpg", DisplayOrder = 2 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy2Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_0.jpg", DisplayOrder = 3 },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/4:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_3.jpg", DisplayOrder = 1 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/2:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_1.jpg", DisplayOrder = 2 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy3Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/1:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_0.jpg", DisplayOrder = 3 },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/4:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_3.jpg", DisplayOrder = 1 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/3:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_2.jpg", DisplayOrder = 2 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy5Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/2:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_1.jpg", DisplayOrder = 3 },

            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/4:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_3.jpg", DisplayOrder = 1 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/3:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_2.jpg", DisplayOrder = 2 },
            new ToyImage { Id = Guid.NewGuid(), ToyId = toy4Id, ImageUrl = "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/2:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_1.jpg", DisplayOrder = 3 }
        );
    }
}
