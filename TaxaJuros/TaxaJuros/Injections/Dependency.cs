using TaxaJuros.Business;
using TaxaJuros.Business.Interface;
using TaxaJuros.Data.Context;
using TaxaJuros.Data.Interface;
using TaxaJuros.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace TaxaJuros.Api.Injections
{
    public static class Dependency
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<ITaxaService, TaxaService>();
            services.AddScoped<ITaxaRepository, TaxaRepository>();
            services.AddSingleton<DataContext>();
        }
    }
}
