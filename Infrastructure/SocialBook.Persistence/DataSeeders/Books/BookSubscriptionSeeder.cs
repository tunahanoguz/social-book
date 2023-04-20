using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookSubscription[] BookSubscriptions => new BookSubscription[]
        {
            new BookSubscription { Id = new Guid(), Book = Books[0], User = Users[2] },
            new BookSubscription { Id = new Guid(), Book = Books[1], User = Users[2] },
            new BookSubscription { Id = new Guid(), Book = Books[2], User = Users[2] },
            new BookSubscription { Id = new Guid(), Book = Books[3], User = Users[2] },
        };

        public static void SeedBookSubscription(this ModelBuilder builder)
        {
            builder.Entity<BookSubscription>().HasData(BookSubscriptions);
        }
    }
}
