using roofstock.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Services
{
    /// <summary>
    /// Provides methods for external API.
    /// </summary>
    public interface IExternalPropertyService
    {
        /// <summary>
        /// Gets all properties from external API.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        Task<List<Property>> GetAllProperties();
    }
}