using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using SocialBook.Application.Interfaces.Services;
using SocialBook.Infrastructure.Services;

namespace SocialBook.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options => { options.Configuration = Configuration.RedisConnectionString; });
            services.AddScoped<ICacheService, CacheService>();

            services.AddSingleton<IElasticClient>(CreateElasticsearchClient(configuration));
        }

        private static IElasticClient CreateElasticsearchClient(IConfiguration configuration)
        {
            string elasticsearchHost = configuration.GetSection("ElasticsearchServer:Host").Value;
            string elasticsearchPort = configuration.GetSection("ElasticsearchServer:Port").Value;
            string elasticsearchUsername = configuration.GetSection("ElasticsearchServer:Username").Value;
            string elasticsearchPassword = configuration.GetSection("ElasticsearchServer:Password").Value;

            var settings = new ConnectionSettings(new Uri($"{elasticsearchHost}:{elasticsearchPort}"));

            if (!string.IsNullOrEmpty(elasticsearchUsername) && !string.IsNullOrEmpty(elasticsearchPassword))
            {
                settings.BasicAuthentication(elasticsearchUsername, elasticsearchPassword);
            }

            return new ElasticClient(settings);
        }
    }
}
