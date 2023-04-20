using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityPostImage[] CommunityPostImages => new CommunityPostImage[]
        {
            new CommunityPostImage { Id = new Guid(), FileName = "community-post-image-1", FileExtension = "png", FileSize = 10, CommunityPost = CommunityPosts[0] },
            new CommunityPostImage { Id = new Guid(), FileName = "community-post-image-2", FileExtension = "png", FileSize = 10, CommunityPost = CommunityPosts[1] }
        };

        public static void SeedCommunityPostImages(this ModelBuilder builder)
        {
            builder.Entity<CommunityPostImage>().HasData(CommunityPostImages);
        }
    }
}
