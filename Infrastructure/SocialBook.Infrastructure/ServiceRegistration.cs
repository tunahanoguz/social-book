using Microsoft.Extensions.DependencyInjection;
using SocialBook.Application.Services.Common;
using SocialBook.Infrastructure.Services;

namespace SocialBook.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddStackExchangeRedisCache(options => { options.Configuration = Configuration.RedisConnectionString; });
            services.AddScoped<ICacheService, CacheService>();
        }
    }
}
