using Microsoft.Extensions.Configuration;

namespace SocialBook.Persistence
{
    static class Configuration
    {
        public static string PostgreSQLConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SocialBook.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
