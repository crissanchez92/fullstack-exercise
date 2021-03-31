using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using roofstock.Api.Adapters;
using roofstock.Api.Mappers;
using roofstock.Api.Services;
using roofstock.Api.Services.Impl;
using roofstock.Data;

namespace roofstock.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConfigurationOptions>(Configuration.GetSection(ConfigurationOptions.Key));

            services.AddControllers();
            services.AddTransient<IExternalPropertyService, ExternalPropertyService>();
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IPropertyAdapter, PropertyAdapter>();

            services.AddRoofstockDbContext(Configuration);

            services.AddAutoMapperConfiguration();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}