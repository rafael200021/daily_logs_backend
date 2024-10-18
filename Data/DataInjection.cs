using daily_log_api.IRepositories;
using daily_log_api.IServices;
using daily_log_api.Models;
using daily_log_api.Repositories;
using daily_log_api.Services;

namespace daily_log_api.Data
{
    public class DataInjection
    {
        public static void Register(IServiceCollection services)
        {

            // DB 

            services.AddDbContext<DbDailyLogContext>();

            // Services

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IDefaultService<>), typeof(DefaultService<>));
            services.AddScoped(typeof(IDefaultService<LogEntry>), typeof(DefaultService<LogEntry>));
            services.AddScoped(typeof(IDefaultService<Log>), typeof(DefaultService<Log>));
            services.AddScoped(typeof(IDefaultService<Template>), typeof(DefaultService<Template>));


            // Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IDefaultRepository<>), typeof(DefaultRepository<>));
            services.AddScoped(typeof(IDefaultRepository<LogEntry>), typeof(DefaultRepository<LogEntry>));
            services.AddScoped(typeof(IDefaultRepository<Log>), typeof(DefaultRepository<Log>));
            services.AddScoped(typeof(IDefaultRepository<Template>), typeof(DefaultRepository<Template>));

        }
    }
}