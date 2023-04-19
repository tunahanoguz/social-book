using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorReview[] AuthorReviews => new AuthorReview[]
        {
            new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", Author = Authors[0], User = Users[2] },
            new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", Author = Authors[1], User = Users[2] }
        };

        public static void SeedAuthorReviews(this ModelBuilder builder)
        {
            builder.Entity<AuthorReview>().HasData(AuthorReviews);
        }
    }
}
