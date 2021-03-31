using roofstock.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Services
{
    public interface IPropertyService
    {
        /// <summary>
        /// Saves the property
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        Property Save(Property property);

        /// <summary>
        /// Gets the property that matches the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Property GetByPropertyId(int id);

        /// <summary>
        /// Gets all properties
        /// </summary>
        /// <returns></returns>
        Task<List<Property>> GetAll();
    }
}