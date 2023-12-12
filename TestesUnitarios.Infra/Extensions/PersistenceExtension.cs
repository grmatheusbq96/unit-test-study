using Microsoft.Extensions.DependencyInjection;
using TestesUnitarios.Domain.Interfaces.Repositories;
using TestesUnitarios.Infra.Context;
using TestesUnitarios.Infra.Repositories;

namespace TestesUnitarios.Infra.Extensions
{
    public static class PersistenceExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<UnitTestContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            return services;
        }
    }
}