using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AppUserRole[] UsersRoles => new AppUserRole[]
        {
            new AppUserRole { UserId = Users[0].Id, RoleId = Roles[0].Id },
            new AppUserRole { UserId = Users[1].Id, RoleId = Roles[1].Id },
            new AppUserRole { UserId = Users[2].Id, RoleId = Roles[2].Id }
        };

        public static void SeedUsersRoles(this ModelBuilder builder)
        {
            builder.Entity<AppUserRole>().HasData(UsersRoles);
        }
    }
}
