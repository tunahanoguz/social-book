using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AppRole[] Roles => new AppRole[]
        {
            new AppRole { Id = new Guid().ToString(), Name = "Admin", NormalizedName = "ADMIN" },
            new AppRole { Id = new Guid().ToString(), Name = "Editor", NormalizedName = "EDITOR" },
            new AppRole { Id = new Guid().ToString(), Name = "Reader", NormalizedName = "READER" }
        };

        public static void SeedUserRoles(this ModelBuilder builder)
        {
            builder.Entity<AppRole>().HasData(Roles);
        }
    }
}
