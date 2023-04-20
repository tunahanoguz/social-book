using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static Community[] Communities => new Community[]
        {
            new Community { Id = new Guid(), Name = "Community 1", Description = "Community 1 description.", OwnerUser = Users[2] },
            new Community { Id = new Guid(), Name = "Community 2", Description = "Community 1 description.", OwnerUser = Users[2] }
        };

        public static void SeedCommunities(this ModelBuilder builder)
        {
            builder.Entity<Community>().HasData(Communities);
        }
    }
}
