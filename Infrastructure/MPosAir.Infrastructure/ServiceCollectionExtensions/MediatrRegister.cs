using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MPosAir.Application.Queries;
using System.Reflection;

namespace MPosAir.Infrastructure.ServiceCollectionExtensions
{
    public static class MediatrRegister
    {
        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(typeof(GetBasketByIdQuery).Assembly, typeof(MediatrRegister).Assembly);
        }
    }
}
