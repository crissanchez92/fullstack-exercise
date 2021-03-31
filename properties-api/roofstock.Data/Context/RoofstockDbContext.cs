using Microsoft.EntityFrameworkCore;
using roofstock.Data.Entities;

namespace roofstock.Data.Context
{
    public class RoofstockDbContext : DbContext, IRoofstockDbContext
    {
        public RoofstockDbContext(DbContextOptions<RoofstockDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>().ToTable("Property")
                // adding unique here since this is not available as annotation
                .HasIndex(p => p.PropertyID)
                .IsUnique();

            modelBuilder.Entity<Address>().ToTable("Address");
        }
    }
}