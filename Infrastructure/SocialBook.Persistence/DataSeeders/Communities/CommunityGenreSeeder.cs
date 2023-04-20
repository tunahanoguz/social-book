using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static CommunityGenre[] CommunityGenres => new CommunityGenre[]
        {
            new CommunityGenre { Id = new Guid(), Community = Communities[0], Genre = Genres[0] },
            new CommunityGenre { Id = new Guid(), Community = Communities[1], Genre = Genres[0] }
        };

        public static void SeedCommunityGenres(this ModelBuilder builder)
        {
            builder.Entity<CommunityGenre>().HasData(CommunityGenres);
        }
    }
}
