// Ignore Spelling: API

using System.Runtime.CompilerServices;

namespace Web_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext();
        }
    }
}
