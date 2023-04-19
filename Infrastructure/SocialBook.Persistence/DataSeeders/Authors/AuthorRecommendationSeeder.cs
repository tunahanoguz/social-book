using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorRecommendation[] AuthorRecommendations => new AuthorRecommendation[]
        {
            new AuthorRecommendation() { Id = new Guid(), Author = Authors[0], RecommenderUser = Users[0], RecipientUser = Users[1] },
            new AuthorRecommendation() { Id = new Guid(), Author = Authors[1], RecommenderUser = Users[0], RecipientUser = Users[1] },
        };

        public static void SeedAuthorRecommendations(this ModelBuilder builder)
        {
            builder.Entity<AuthorRecommendation>().HasData(AuthorRecommendations);
        }
    }
}
