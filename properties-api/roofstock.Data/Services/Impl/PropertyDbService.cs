using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using roofstock.Data.Context;
using roofstock.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roofstock.Data.Services.Impl
{
    public class PropertyDbService : IPropertyDbService
    {
        private readonly RoofstockDbContext context;
        private readonly ILogger logger;

        public PropertyDbService(RoofstockDbContext context, ILogger<PropertyDbService> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task<List<Property>> GetAll()
        {
            return await this.context
                .Properties
                .Include(p => p.Address)
                .ToListAsync();
        }

        public Property GetByPropertyId(int propertyID)
        {
            return this.context
                .Properties
                .FirstOrDefault(p => p.PropertyID == propertyID);
        }

        public Property Save(Property property)
        {
            if(this.context.Properties.Any(p => p.PropertyID == property.PropertyID))
            {
                this.logger.LogError($"Property [{property.PropertyID}] already exist");
                throw new ArgumentException($"Property [{property.PropertyID}] already exist");
            }

            this.context.Properties.Add(property);

            if(this.context.SaveChanges() > 0)
            {
                this.logger.LogInformation($"Property with id: [{property.PropertyID}] has been saved");
                return property;
            }
            else
            {
                this.logger.LogError($"Property [{property.PropertyID}] could not been saved");
                throw new ApplicationException($"Property [{property.PropertyID}] could not been saved");
            }
        }
    }
}