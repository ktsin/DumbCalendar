using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DAL.Repositories.EFCore;

namespace DAL
{
    public static class Configure
    {
        public static IServiceCollection ConfigureDAL(this IServiceCollection services, IConfiguration configuration)
        {
            string conStr = configuration.GetConnectionString("MainData");
            services.AddDbContext<DataContext>();
            return services;
        }
    }
}
