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
    /// <summary>
    /// Provides methods to manage Property entity in the dbContext.
    /// </summary>
    public class PropertyDbService : IPropertyDbService
    {
        private readonly RoofstockDbContext context;
        private readonly ILogger logger;

        public PropertyDbService(RoofstockDbContext context, ILogger<PropertyDbService> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <summary>
        /// Gets all properties from the dbContext.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        public async Task<List<Property>> GetAll()
        {
            return await this.context
                .Properties
                .Include(p => p.Address)
                .ToListAsync();
        }

        /// <summary>
        /// Gets property from dbContext that mathes the given propertyID.
        /// </summary>
        /// <param name="propertyID"></param>
        /// <returns>The property found or null.</returns>
        public Property GetByPropertyId(int propertyID)
        {
            return this.context
                .Properties
                .Include(p => p.Address)
                .FirstOrDefault(p => p.PropertyID == propertyID);
        }

        /// <summary>
        /// Saves the property into the dbContext.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The property saved including its generated ID.</returns>
        public Property Save(Property property)
        {
            // Verifies if the property already exist in database to avoid duplicates
            if(this.context.Properties.Any(p => p.PropertyID == property.PropertyID))
            {
                this.logger.LogError($"Property [{property.PropertyID}] already exist");
                throw new ArgumentException($"Property [{property.PropertyID}] already exist");
            }

            this.context.Properties.Add(property);

            // Saves the property in the database
            if(this.context.SaveChanges() > 0)
            {
                // Logs if the property was successfully saved
                this.logger.LogInformation($"Property with id: [{property.PropertyID}] has been saved");
                return property;
            }
            else
            {
                // Logs if the property could not be saved.
                this.logger.LogError($"Property [{property.PropertyID}] could not been saved");
                throw new ApplicationException($"Property [{property.PropertyID}] could not been saved");
            }
        }
    }
}