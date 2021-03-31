using Microsoft.Extensions.DependencyInjection;

namespace roofstock.Api.Mappers
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntitiesProfile));
        }
    }
}