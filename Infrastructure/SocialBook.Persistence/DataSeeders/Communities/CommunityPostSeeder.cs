using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityPost[] CommunityPosts => new CommunityPost[]
        {
            new CommunityPost { Id = new Guid(), Title = "Community Post 1", Body = "Community Post 1 body.", Community = Communities[0], User = Users[2] },
            new CommunityPost { Id = new Guid(), Title = "Community Post 2", Body = "Community Post 2 body.", Community = Communities[1], User = Users[2] },
        };

        public static void SeedCommunityPosts(this ModelBuilder builder)
        {
            builder.Entity<CommunityPost>().HasData(CommunityPosts);
        }
    }
}
