using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Common;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static SiteSetting[] SiteSettings => new SiteSetting[]
        {
            new SiteSetting
            {
                Id = new Guid(),
                Title = "Social Book",
                MetaDescription = "Meta description for social book",
                MetaKeywords = "Meta keywords for social book",
                PageTitleSeperator = "-"
            }
        };

        public static void SeedSiteSettings(this ModelBuilder builder)
        {
            builder.Entity<SiteSetting>().HasData(SiteSettings);
        }
    }
}
