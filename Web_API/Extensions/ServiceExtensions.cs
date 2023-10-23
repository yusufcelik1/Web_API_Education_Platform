// Ignore Spelling: API

using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Repositories_Education_Platform;
using Repositories_Education_Platform.Contracts;
using Repositories_Education_Platform.EFCore;

namespace Web_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("")));
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
