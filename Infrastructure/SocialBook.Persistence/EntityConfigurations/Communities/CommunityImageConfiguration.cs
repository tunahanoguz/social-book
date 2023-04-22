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
                new CommunityImage { Id = new Guid("b477d72f-1f05-411c-8448-515e91dd75d8"), FileName = "community-profile-image-1", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("0e7ed195-1fb5-4a4a-94c9-36a421d52deb"), FileName = "community-profile-image-2", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("1309047f-eac7-4a9c-b731-b4379e01ddbe"), FileName = "community-profile-image-3", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("669d1738-5abc-4d85-bf4d-3612975b8c75"), FileName = "community-profile-image-4", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("6e05c37a-c4da-4dd7-95d8-d78fc7bdd436"), FileName = "community-cover-image-1", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("4b83ca08-b55c-4581-84d0-6daeeca8929a"), FileName = "community-cover-image-2", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("9b52fb7d-99e3-49a1-8681-bc43a704e17e"), FileName = "community-cover-image-3", FileExtension = "png", FileSize = 10 },
                new CommunityImage { Id = new Guid("3550912e-f963-42f2-bdeb-f3f89736e67a"), FileName = "community-cover-image-4", FileExtension = "png", FileSize = 10 }
            );
        }
    }
}
