using Microsoft.EntityFrameworkCore;
using roofstock.Data.Entities;

namespace roofstock.Data.Context
{
    public interface IRoofstockDbContext
    {
        DbSet<Property> Properties { get; set; }
        DbSet<Address> Addresses { get; set; }
    }
}