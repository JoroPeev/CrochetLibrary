using CrochetLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Data;
public class CrochetDbContext : DbContext
{
    public CrochetDbContext(DbContextOptions<CrochetDbContext> options) : base(options) { }

    public DbSet<Toy> Toys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Toy>()
            .Property(t => t.Price)
            .HasPrecision(10, 2);
    }
}

