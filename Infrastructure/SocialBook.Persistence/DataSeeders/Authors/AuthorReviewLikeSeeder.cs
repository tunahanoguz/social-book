using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorReviewLike[] AuthorReviewLikes = new AuthorReviewLike[]
        {
            new AuthorReviewLike { Id = new Guid(), AuthorReview = AuthorReviews[0], User = Users[1] },
            new AuthorReviewLike { Id = new Guid(), AuthorReview = AuthorReviews[1], User = Users[1] },
            new AuthorReviewLike { Id = new Guid(), AuthorReview = AuthorReviews[2], User = Users[0] },
            new AuthorReviewLike { Id = new Guid(), AuthorReview = AuthorReviews[3], User = Users[0] },
        };

        public static void SeedAuthorReviewLikes(this ModelBuilder builder)
        {
            builder.Entity<AuthorReviewLike>().HasData(AuthorReviewLikes);
        }
    }
}
