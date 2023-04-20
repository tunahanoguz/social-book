using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookReview[] BookReviews => new BookReview[]
        {
            new BookReview { Id = new Guid(), Rating = 10, Comment = "A great book.", Book = Books[0], User = Users[2] },
            new BookReview { Id = new Guid(), Rating = 10, Comment = "A great book.", Book = Books[1], User = Users[2] },
            new BookReview { Id = new Guid(), Rating = 10, Comment = "A great book.", Book = Books[2], User = Users[2] },
            new BookReview { Id = new Guid(), Rating = 10, Comment = "A great book.", Book = Books[3], User = Users[2] }
        };

        public static void SeedBookReviews(this ModelBuilder builder)
        {
            builder.Entity<BookReview>().HasData(BookReviews);
        }
    }
}
