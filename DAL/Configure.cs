using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DAL.Repositories.EFCore;
using DAL.Repositories.Interfaces;
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
            services.AddScoped<ICalendarEventsRepository, CalendarEventsRepository>();
            services.AddScoped<IGroupsRepository, GroupsRepository>();
            services.AddScoped<IMessagesRepository, MessagesRepository>();
            services.AddScoped<IProjectsRepository, ProjectsRepository>();
            services.AddScoped<IProjectTasksRepository, ProjectTasksRepository>();
            services.AddScoped<ITagsRepository, TagsRepository>();
            services.AddScoped<IUserRepository, UsersRepository>();
            
            return services;
        }
    }
}
