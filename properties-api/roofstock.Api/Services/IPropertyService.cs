using roofstock.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Services
{
    /// <summary>
    /// Provides crud operations for Property model.
    /// </summary>
    public interface IPropertyService
    {
        /// <summary>
        /// Sends the property to save to DbService.
        /// Translates the property into dbContext entity to save.
        /// And translates the dbContext entity into property.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The property saved including its generated ID.</returns>
        Property Save(Property property);

        /// <summary>
        /// Gets the property that matches the given propertyID from the dbService.
        /// </summary>
        /// <param name="propertyID"></param>
        /// <returns>The property found or null.</returns>
        Property GetByPropertyId(int propertyID);

        /// <summary>
        /// Gets all properties from the dbService.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        Task<List<Property>> GetAll();
    }
}