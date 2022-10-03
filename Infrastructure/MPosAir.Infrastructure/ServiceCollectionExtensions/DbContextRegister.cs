using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MPosAir.Infrastructure.ServiceCollectionExtensions
{
    public static class DbContextRegister
    {
        public static void AddSqlServerDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MPosAirDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
