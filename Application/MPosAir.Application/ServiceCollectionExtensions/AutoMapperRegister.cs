using Microsoft.Extensions.DependencyInjection;
using MPosAir.Application.AutoMapper;

namespace MPosAir.Application.ServiceCollectionExtensions
{
    public static class AutoMapperRegister
    {
        public static void AddAppLayerAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
        }
    }
}
