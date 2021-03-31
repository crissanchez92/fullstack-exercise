using roofstock.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Data.Services
{
    public interface IPropertyDbService
    {
        /// <summary>
        /// Gets all properties
        /// </summary>
        /// <returns></returns>
        Task<List<Property>> GetAll();

        /// <summary>
        /// Gets property that mathes the given propertyID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Property GetByPropertyId(int propertyID);

        /// <summary>
        /// Saves the property
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        Property Save(Property property);
    }
}