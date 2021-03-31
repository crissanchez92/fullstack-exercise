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