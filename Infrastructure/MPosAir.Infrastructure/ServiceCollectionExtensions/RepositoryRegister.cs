using Microsoft.Extensions.DependencyInjection;
using MPosAir.Application.Repositories;
using MPosAir.Infrastructure.Repositories;

namespace MPosAir.Infrastructure.ServiceCollectionExtensions
{
    public static class RepositoryRegister
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBasketRepository, BasketRepository>();
        }
    }
}
