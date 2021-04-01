using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using roofstock.Api.Adapters;
using roofstock.Api.Mappers;
using roofstock.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace roofstock.Api.Services.Impl
{
    /// <summary>
    /// Provides methods for external API.
    /// </summary>
    public class ExternalPropertyService : IExternalPropertyService
    {
        private readonly ConfigurationOptions options;
        private readonly IPropertyAdapter adapter;
        private readonly ILogger<ExternalPropertyService> logger;

        public ExternalPropertyService(
            IOptions<ConfigurationOptions> options,
            IPropertyAdapter adapter,
            ILogger<ExternalPropertyService> logger)
        {
            this.options = options.Value;
            this.adapter = adapter;
            this.logger = logger;
        }

        /// <summary>
        /// Gets all properties from external API.
        /// </summary>
        /// <returns>The list of properties found.</returns>
        public async Task<List<Property>> GetAllProperties()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    var response = await wc.DownloadStringTaskAsync(options.DataSource);

                    // Deserialize the response into classes to manipulate the json as objects.
                    var propertiesMap = JsonSerializer.Deserialize<PropertiesPoco>(response);

                    // Adapts the PropertiesPoco object into list of Property models.
                    List<Property> properties = propertiesMap.properties.Select(p => adapter.Adapt(p)).ToList();
                    return properties;
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw;
            }
        }
    }
}