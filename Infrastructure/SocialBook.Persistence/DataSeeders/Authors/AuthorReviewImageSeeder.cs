using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorReviewImage[] AuthorReviewImages => new AuthorReviewImage[]
        {
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-1", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[0] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-2", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[0] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-3", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[1] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-4", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[1] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-5", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[2] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-6", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[2] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-7", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[3] },
            new AuthorReviewImage { Id = new Guid(), FileName = "charles-dickens-review-8", FileExtension = "png", FileSize = 32, AuthorReview = AuthorReviews[3] },
        };

        public static void SeedAuthorReviewImages(this ModelBuilder builder)
        {
            builder.Entity<AuthorReviewImage>().HasData(AuthorReviewImages);
        }
    }
}
