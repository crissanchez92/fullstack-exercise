using Microsoft.AspNetCore.Mvc;
using roofstock.Api.Models;
using roofstock.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExternalPropertyController
    {
        private readonly IExternalPropertyService propertyService;

        public ExternalPropertyController(IExternalPropertyService propertyService)
        {
            this.propertyService = propertyService;
        }

        [HttpGet]
        public async Task<IEnumerable<Property>> GetAll()
        {
            return await this.propertyService.GetAllProperties();
        }
    }
}