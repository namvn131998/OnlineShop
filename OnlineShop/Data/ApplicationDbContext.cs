using OnlineShop.Models;
using Microsoft.EntityFrameworkCore;
/*using System.Data.Entity;*/

namespace OnlineShop.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Student & StudentAddress entity
        modelBuilder.Entity<Category>();
        modelBuilder.Entity<Product>();
        modelBuilder.Entity<Brand>();
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
}

