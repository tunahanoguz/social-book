using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static UserSocialMediaPlatform[] UserSocialMediaPlatforms => new UserSocialMediaPlatform[]
        {
            new UserSocialMediaPlatform { Id = new Guid(), Name = "Facebook", UrlPrefix = "https://www.facebook.com/", UrlPostfix = null },
            new UserSocialMediaPlatform { Id = new Guid(), Name = "Twitter", UrlPrefix = "https://twitter.com/", UrlPostfix = null },
            new UserSocialMediaPlatform { Id = new Guid(), Name = "Instagram", UrlPrefix = "https://www.instagram.com/", UrlPostfix = null },
            new UserSocialMediaPlatform { Id = new Guid(), Name = "LinkedIn", UrlPrefix = "https://www.linkedin.com/in/", UrlPostfix = null },
        };

        public static void SeedUserSocialMediaPlatforms(this ModelBuilder builder)
        {
            builder.Entity<UserSocialMediaPlatform>().HasData(UserSocialMediaPlatforms);
        }
    }
}
