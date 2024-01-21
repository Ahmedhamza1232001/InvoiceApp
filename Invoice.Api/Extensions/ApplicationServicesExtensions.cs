using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Invoice.Infrastructure;

namespace SmartShop.API.Extensions;

public static class ApplicationServicesExtensions
{

    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config, IWebHostEnvironment hostingEnvironment)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
       

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(
                config.GetConnectionString("DefaultConnection"),
                sqlServerOptions =>
                {
                    sqlServerOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                    // Additional SQL Server options if needed
                    // sqlServerOptions.CommandTimeout(60);
                }
            );
        });

        return services;
    }
}

