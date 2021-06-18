using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DAL.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class Configure
    {
        public static IServiceCollection ConfigureDAL(this IServiceCollection services, IConfiguration configuration)
        {
            string conStr = configuration.GetConnectionString("MainData");
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                opt.UseSqlite(conStr);
            });
            return services;
        }
    }
}
