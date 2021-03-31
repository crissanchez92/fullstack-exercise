using roofstock.Api.Mappers;
using roofstock.Api.Models;
using System;

namespace roofstock.Api.Adapters
{
    public class PropertyAdapter : IPropertyAdapter
    {
        public Property Adapt(object item)
        {
            try
            {
                var propertyPoco = item as PropertyPoco;

                if (propertyPoco is null)
                {
                    throw new ArgumentException($"Parameter type {item.GetType()} is not valid");
                }

                return new Property
                {
                    PropertyID = propertyPoco.id,
                    ListPrice = propertyPoco.financial?.listPrice,
                    MonthlyRent = propertyPoco.financial?.monthlyRent,
                    YearBuilt = propertyPoco.physical?.yearBuilt,
                    Address = new Address
                    {
                        Address1 = propertyPoco.address?.address1,
                        Address2 = propertyPoco.address?.address2,
                        City = propertyPoco.address?.city,
                        Country = propertyPoco.address?.country,
                        County = propertyPoco.address?.county,
                        District = propertyPoco.address?.district,
                        State = propertyPoco.address?.state,
                        Zip = propertyPoco.address?.zip,
                        ZipPlus4 = propertyPoco.address?.zipPlus4
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}