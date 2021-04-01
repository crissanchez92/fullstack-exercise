using Microsoft.Extensions.DependencyInjection;

namespace roofstock.Api.Mappers
{
    /// <summary>
    /// Provides AutoMapper custom configuration.
    /// </summary>
    public static class AutoMapperConfiguration
    {
        /// <summary>
        /// Registers the mapping profiles into the services collection.
        /// </summary>
        /// <param name="services"></param>
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntitiesProfile));
        }
    }
}