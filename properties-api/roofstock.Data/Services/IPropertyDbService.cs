using roofstock.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Data.Services
{
    /// <summary>
    /// Provides methods to manage Property entity in the dbContext.
    /// </summary>
    public interface IPropertyDbService
    {
        /// <summary>
        /// Gets all properties from the dbContext.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        Task<List<Property>> GetAll();

        /// <summary>
        /// Gets property from dbContext that mathes the given propertyID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The property found or null.</returns>
        Property GetByPropertyId(int propertyID);

        /// <summary>
        /// Saves the property into the dbContext.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The property saved including its generated ID.</returns>
        Property Save(Property property);
    }
}