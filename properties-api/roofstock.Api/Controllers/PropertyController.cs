using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using roofstock.Api.Models;
using roofstock.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace roofstock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService service;

        public PropertyController(IPropertyService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<Property>> GetAll()
        {
            return await this.service.GetAll();
        }

        [HttpGet]
        [Route("{propertyID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetByPropertyId(int propertyID)
        {
            var property = this.service.GetByPropertyId(propertyID);
            if(property == null)
            {
                return this.NotFound();
            }

            return this.Ok(property);
        }

        [HttpPost]
        public Property Save(Property property)
        {
            return this.service.Save(property);
        }
    }
}