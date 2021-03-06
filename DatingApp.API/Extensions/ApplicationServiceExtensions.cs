using System;
using DatingApp.API.Database.Repositories;
using DatingApp.API.Services;
using DatingApp.DatingApp.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Namespace;

namespace DatingApp.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(UserMapperProfile).Assembly);

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(connectionString, serverVersion)
                    .EnableSensitiveDataLogging() // <-- These two calls are optional but help
                    .EnableDetailedErrors()       // <-- with debugging (remove for production).
            );
            return services;
        }
    }
}