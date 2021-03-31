using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace roofstock.Data.Context
{
    public class RoofstockDbContextFactory : IDesignTimeDbContextFactory<RoofstockDbContext>
    {
        public RoofstockDbContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()
                .Replace("Data", "Api"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<RoofstockDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new RoofstockDbContext(optionsBuilder.Options);
        }
    }
}