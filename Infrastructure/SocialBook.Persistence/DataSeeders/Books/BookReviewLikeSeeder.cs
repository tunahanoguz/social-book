using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookReviewLike[] BookReviewLikes => new BookReviewLike[]
        {
            new BookReviewLike { Id = new Guid(), BookReview = BookReviews[0], User = Users[2] },
            new BookReviewLike { Id = new Guid(), BookReview = BookReviews[1], User = Users[2] },
            new BookReviewLike { Id = new Guid(), BookReview = BookReviews[2], User = Users[2] },
            new BookReviewLike { Id = new Guid(), BookReview = BookReviews[3], User = Users[2] },
        };

        public static void SeedBookReviewLikes(this ModelBuilder builder)
        {
            builder.Entity<BookReviewLike>().HasData(BookReviewLikes);
        }
    }
}
