using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityImageConfiguration : IEntityTypeConfiguration<CommunityImage>
    {
        public void Configure(EntityTypeBuilder<CommunityImage> builder)
        {
            builder.HasData(
                new CommunityImage { Id = new Guid("b68db3e2-ab70-4514-b6ac-037ed4e1cf3a"), FileName = "community-profile-image-1", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("ef0e9bfb-17da-4964-beb8-2d30c85397a6"), FileName = "community-profile-image-2", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("afafaa3a-e48b-44ab-b150-78dac555f683"), FileName = "community-cover-image-1", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("4d01c9d2-a045-47d1-8e3e-cbe50ed39c6c"), FileName = "community-cover-image-2", FileExtension = "png", FileSize = 10 }
            );
        }
    }
}
