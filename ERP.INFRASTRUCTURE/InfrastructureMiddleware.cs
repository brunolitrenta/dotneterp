using ERP.APPLICATION;
using ERP.INFRASTRUCTURE.Persistence;
using ERP.INFRASTRUCTURE.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.INFRASTRUCTURE;

public static class InfrastructureMiddleware
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ErpDBContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("PostgresDb"))
        );
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
    }
    
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDatabase(services, configuration);
        AddRepositories(services);
    }
}