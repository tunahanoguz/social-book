using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations.Users
{
    public class UserSocialMediaPlatformConfiguration : IEntityTypeConfiguration<UserSocialMediaPlatform>
    {
        public void Configure(EntityTypeBuilder<UserSocialMediaPlatform> builder)
        {
            builder.HasData(
                new UserSocialMediaPlatform { Id = new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), Name = "Facebook", UrlPrefix = "https://www.facebook.com/", UrlPostfix = null },
                new UserSocialMediaPlatform { Id = new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), Name = "Twitter", UrlPrefix = "https://twitter.com/", UrlPostfix = null },
                new UserSocialMediaPlatform { Id = new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), Name = "Instagram", UrlPrefix = "https://www.instagram.com/", UrlPostfix = null },
                new UserSocialMediaPlatform { Id = new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), Name = "LinkedIn", UrlPrefix = "https://www.linkedin.com/in/", UrlPostfix = null },
            );
        }
    }
}
