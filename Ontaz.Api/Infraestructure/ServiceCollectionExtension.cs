using Microsoft.Extensions.DependencyInjection;
using Ontaz.Service.InterfaceServices;
using Ontaz.Service.Service;

namespace Ontaz.Api.Infraestructure
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureServices(this IServiceCollection service)
        {
            service.AddTransient<ICountryService, CountryService>();
            service.AddTransient<ICategoryService, CategoryService>();
            service.AddTransient<IServiceService, ServiceService>();
            service.AddTransient<IProductService, ProductService>();
        }
    }
}
