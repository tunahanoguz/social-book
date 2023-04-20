using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityImage[] CommunityImages => new CommunityImage[]
        {
            new CommunityImage { Id = new Guid(), FileName = "community-profile-image-1", FileExtension = "png", FileSize = 10 },
            new CommunityImage { Id = new Guid(), FileName = "community-profile-image-2", FileExtension = "png", FileSize = 10 },
            new CommunityImage { Id = new Guid(), FileName = "community-cover-image-1", FileExtension = "png", FileSize = 10 },
            new CommunityImage { Id = new Guid(), FileName = "community-cover-image-2", FileExtension = "png", FileSize = 10 }
        };

        public static void SeedCommunityImages(this ModelBuilder builder)
        {
            builder.Entity<CommunityImage>().HasData(CommunityImages);
        }
    }
}
