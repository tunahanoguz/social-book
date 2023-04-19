using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorReviewDislike[] AuthorReviewDislikes => new AuthorReviewDislike[]
        {
            new AuthorReviewDislike { Id = new Guid(), AuthorReview = AuthorReviews[0], User = Users[2] },
            new AuthorReviewDislike { Id = new Guid(), AuthorReview = AuthorReviews[1], User = Users[2] },
            new AuthorReviewDislike { Id = new Guid(), AuthorReview = AuthorReviews[2], User = Users[2] },
            new AuthorReviewDislike { Id = new Guid(), AuthorReview = AuthorReviews[3], User = Users[2] },
        };

        public static void SeedAuthorReviewDislikes(this ModelBuilder builder)
        {
            builder.Entity<AuthorReviewDislike>().HasData(AuthorReviewDislikes);
        }
    }
}
