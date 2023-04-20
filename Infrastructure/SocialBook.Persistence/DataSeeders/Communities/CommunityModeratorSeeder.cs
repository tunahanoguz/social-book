using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityModerator[] CommunityModerators => new CommunityModerator[]
        {
            new CommunityModerator { Id = new Guid(), Community = Communities[0], User = Users[2] },
            new CommunityModerator { Id = new Guid(), Community = Communities[1], User = Users[2] }
        };

        public static void SeedCommunityModerators(this ModelBuilder builder)
        {
            builder.Entity<CommunityModerator>().HasData(CommunityModerators);
        }
    }
}
