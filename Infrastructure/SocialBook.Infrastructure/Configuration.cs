using Microsoft.Extensions.Configuration;

namespace SocialBook.Infrastructure
{
    static class Configuration
    {
        public static string RedisConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SocialBook.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("Redis");
            }
        }
    }
}
