using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations.Users
{
    public class UserImageConfiguration : IEntityTypeConfiguration<UserImage>
    {
        public void Configure(EntityTypeBuilder<UserImage> builder)
        {
            builder.HasData(
                new UserImage { Id = new Guid("930e5e8f-f3d0-4b27-b357-109d610b5441"), FileName = "user-profile-image-1", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("ec4eec0a-9030-493d-9e9b-5b81a557eda3"), FileName = "user-cover-image-1", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("c671e4d3-4f6d-40f9-ae24-cbde71b2a965"), FileName = "user-profile-image-2", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("3912062f-391e-4536-9a7a-58d3267b4c4e"), FileName = "user-cover-image-2", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("712af0fc-9685-4d0d-b227-b3b4b9f18bb5"), FileName = "user-profile-image-3", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("c34a9c24-9062-4a60-a368-d6c404baaf4e"), FileName = "user-cover-image-3", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("677aa387-ec60-4995-9911-102d209fc199"), FileName = "user-profile-image-4", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new UserImage { Id = new Guid("f37b2aa7-0c53-4b45-ad57-86c968d6ca51"), FileName = "user-cover-image-4", FileExtension = "png", FileSize = 10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
