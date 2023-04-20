using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static UserWantToReadBook[] UserWantToReadBooks => new UserWantToReadBook[]
        {
            new UserWantToReadBook { Id = new Guid(), Book = Books[0], User = Users[2] },
            new UserWantToReadBook { Id = new Guid(), Book = Books[1], User = Users[2] },
            new UserWantToReadBook { Id = new Guid(), Book = Books[2], User = Users[2] },
            new UserWantToReadBook { Id = new Guid(), Book = Books[3], User = Users[2] },
        };

        public static void SeedUserWantToReadBooks(this ModelBuilder builder)
        {
            builder.Entity<UserWantToReadBook>().HasData(UserWantToReadBooks);
        }
    }
}
