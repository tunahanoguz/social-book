using Microsoft.Extensions.DependencyInjection;
using SocialBook.Application.Services.Common;
using SocialBook.Infrastructure.Services;

namespace SocialBook.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ICacheService, CacheService>();
        }
    }
}
