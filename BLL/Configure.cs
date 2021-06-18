using System;
using BLL.Calendar;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class Configure
    {
        public static IServiceCollection ConfigureBLL(this IServiceCollection services, IConfiguration config)
        {
            services.ConfigureDAL(config);
            services.AddScoped<CalendarService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
