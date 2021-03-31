using Microsoft.Extensions.Options;
using roofstock.Api.Adapters;
using roofstock.Api.Mappers;
using roofstock.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace roofstock.Api.Services.Impl
{
    public class ExternalPropertyService : IExternalPropertyService
    {
        private readonly ConfigurationOptions _options;
        private readonly IPropertyAdapter adapter;

        public ExternalPropertyService(
            IOptions<ConfigurationOptions> options,
            IPropertyAdapter adapter)
        {
            this._options = options.Value;
            this.adapter = adapter;
        }

        public async Task<List<Property>> GetAllProperties()
        {
            using (WebClient wc = new WebClient())
            {
                var response = await wc.DownloadStringTaskAsync(_options.DataSource);
                var propertiesMap = JsonSerializer.Deserialize<PropertiesPoco>(response);
                List<Property> properties = propertiesMap.properties.Select(p => adapter.Adapt(p)).ToList();
                return properties;
            }
        }
    }
}