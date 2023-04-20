using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookReviewImage[] BookReviewImages => new BookReviewImage[]
        {
            new BookReviewImage { Id = new Guid(), FileName = "book-review-1", FileExtension = "png", FileSize = 10, BookReview = BookReviews[0] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-2", FileExtension = "png", FileSize = 10, BookReview = BookReviews[0] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-3", FileExtension = "png", FileSize = 10, BookReview = BookReviews[1] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-4", FileExtension = "png", FileSize = 10, BookReview = BookReviews[1] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-5", FileExtension = "png", FileSize = 10, BookReview = BookReviews[2] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-6", FileExtension = "png", FileSize = 10, BookReview = BookReviews[2] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-7", FileExtension = "png", FileSize = 10, BookReview = BookReviews[3] },
            new BookReviewImage { Id = new Guid(), FileName = "book-review-8", FileExtension = "png", FileSize = 10, BookReview = BookReviews[3] },
        };

        public static void SeedBookReviewImages(this ModelBuilder builder)
        {
            builder.Entity<BookReviewImage>().HasData(BookReviewImages);
        }
    }
}
