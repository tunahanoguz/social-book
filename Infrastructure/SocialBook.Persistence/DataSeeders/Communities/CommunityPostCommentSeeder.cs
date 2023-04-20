using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityPostComment[] CommunityPostComments => new CommunityPostComment[]
        {
            new CommunityPostComment { Id = new Guid(), Body = "Community post comment body.", CommunityPost = CommunityPosts[0], ParentComment = null, User = Users[2] },
            new CommunityPostComment { Id = new Guid(), Body = "Community post comment body.", CommunityPost = CommunityPosts[1], ParentComment = null, User = Users[2] }
        };

        public static void SeedCommunityPostComments(this ModelBuilder builder)
        {
            builder.Entity<CommunityPostComment>().HasData(CommunityPostComments);
        }
    }
}
