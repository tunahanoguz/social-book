using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorRecommendation[] AuthorRecommendations => new AuthorRecommendation[]
        {
            new AuthorRecommendation() { Id = new Guid(), Author = Authors[0], RecommenderUser = Users[1], RecipientUser = Users[2] }
        };

        public static void SeedAuthorRecommendations(this ModelBuilder builder)
        {
            builder.Entity<AuthorRecommendation>().HasData(AuthorRecommendations);
        }
    }
}
