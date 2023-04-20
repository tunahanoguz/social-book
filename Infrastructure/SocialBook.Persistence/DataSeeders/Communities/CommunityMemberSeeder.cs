using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityMember[] CommunityMembers => new CommunityMember[]
        {
            new CommunityMember { Id = new Guid(), Community = Communities[0], User = Users[2] },
            new CommunityMember { Id = new Guid(), Community = Communities[1], User = Users[2] },
        };

        public static void SeedCommunityMembers(this ModelBuilder builder)
        {
            builder.Entity<CommunityMember>().HasData(CommunityMembers);
        }
    }
}
