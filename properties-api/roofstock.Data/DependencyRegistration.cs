using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using roofstock.Data.Context;
using roofstock.Data.Services;
using roofstock.Data.Services.Impl;
using System;

namespace roofstock.Data
{
    public static class DependencyRegistration
    {
        public static void AddRoofstockDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            if(configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            // services registration
            services.AddTransient<IPropertyDbService, PropertyDbService>();

            // db context registration
            services.AddDbContext<RoofstockDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}