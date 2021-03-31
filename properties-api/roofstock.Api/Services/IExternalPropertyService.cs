using roofstock.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Services
{
    public interface IExternalPropertyService
    {
        /// <summary>
        /// Gets all properties from external
        /// </summary>
        /// <returns></returns>
        Task<List<Property>> GetAllProperties();
    }
}