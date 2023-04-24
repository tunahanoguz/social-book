using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations.Users
{
    public class UserSocialMediaConfiguration : IEntityTypeConfiguration<UserSocialMedia>
    {
        public void Configure(EntityTypeBuilder<UserSocialMedia> builder)
        {
            builder.HasData(
                new UserSocialMedia { Id = new Guid("3993af16-4d0b-4480-97a7-2da2a24974b4"), UserName = "username", SocialMediaPlatformId = new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("7003b4a6-709b-4e5c-a979-fc15e6452f65"), UserName = "username", SocialMediaPlatformId = new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("e0550f6f-8dd1-4b44-b498-3cce15389b65"), UserName = "username", SocialMediaPlatformId = new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("1dbb185f-30bc-4296-89c6-7cddc4340129"), UserName = "username", SocialMediaPlatformId = new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("0503a657-f0e1-4d9c-8522-62f2dab9c121"), UserName = "username", SocialMediaPlatformId = new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("276a6ac7-5724-4711-916c-3b0dacda1523"), UserName = "username", SocialMediaPlatformId = new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("710d7b9d-34d5-4354-a392-cab90cf6ef52"), UserName = "username", SocialMediaPlatformId = new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserSocialMedia { Id = new Guid("02f57587-4eac-4399-86cc-49c495e6ed9f"), UserName = "username", SocialMediaPlatformId = new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
