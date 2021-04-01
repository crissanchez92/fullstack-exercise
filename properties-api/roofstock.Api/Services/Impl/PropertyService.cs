using AutoMapper;
using Microsoft.Extensions.Logging;
using roofstock.Api.Models;
using roofstock.Data.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DB = roofstock.Data.Entities;

namespace roofstock.Api.Services.Impl
{
    /// <summary>
    /// /// Provides crud operations for Property model.
    /// </summary>
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyDbService dbService;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public PropertyService(
            IPropertyDbService service,
            IMapper mapper,
            ILogger<PropertyService> logger
            )
        {
            this.dbService = service;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <summary>
        /// Gets all properties from the dbService.
        /// Maps the response Property into Property model.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        public async Task<List<Property>> GetAll()
        {
            try
            {
                var propertiesDb = await this.dbService.GetAll();
                var result = this.mapper.Map<List<Property>>(propertiesDb);
                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Gets a single property from the dbService.
        /// Maps the response Property into Property model.
        /// </summary>
        /// <param name="propertyID"></param>
        /// <returns>The property found or null.</returns>
        public Property GetByPropertyId(int propertyID)
        {
            try
            {
                var propertyDb = this.dbService.GetByPropertyId(propertyID);
                var result = this.mapper.Map<Property>(propertyDb);
                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Sends the property to save to DbService.
        /// Translates the property into dbContext entity to save.
        /// And translates the dbContext entity into property.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The property saved including its generated ID.</returns>
        public Property Save(Property property)
        {
            try
            {
                var propertyDb = this.mapper.Map<DB.Property>(property);
                var savedPropertyDb = this.dbService.Save(propertyDb);
                var result = this.mapper.Map<Property>(savedPropertyDb);
                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw;
            }
        }
    }
}