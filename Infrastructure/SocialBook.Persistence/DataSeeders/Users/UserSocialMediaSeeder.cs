using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static UserSocialMedia[] UserSocialMedia => new UserSocialMedia[]
        {
            new UserSocialMedia { Id = new Guid(), UserName = "username", SocialMediaPlatform = UserSocialMediaPlatforms[0], User = Users[2] },
            new UserSocialMedia { Id = new Guid(), UserName = "username", SocialMediaPlatform = UserSocialMediaPlatforms[1], User = Users[2] },
            new UserSocialMedia { Id = new Guid(), UserName = "username", SocialMediaPlatform = UserSocialMediaPlatforms[2], User = Users[2] },
            new UserSocialMedia { Id = new Guid(), UserName = "username", SocialMediaPlatform = UserSocialMediaPlatforms[3], User = Users[2] }
        };

        public static void SeedUserSocialMedia(this ModelBuilder builder)
        {
            builder.Entity<UserSocialMedia>().HasData(UserSocialMedia);
        }
    }
}
