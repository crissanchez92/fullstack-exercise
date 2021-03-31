using AutoMapper;
using roofstock.Api.Models;
using DB = roofstock.Data.Entities;

namespace roofstock.Api.Mappers
{
    public class EntitiesProfile : Profile
    {
        public EntitiesProfile()
        {
            // Maps from db entities to dto classes
            CreateMap<DB.Property, Property>();
            CreateMap<DB.Address, Address>();

            // Maps from dto classes to db entities
            CreateMap<Property, DB.Property>();
            CreateMap<Address, DB.Address>();
        }
    }
}