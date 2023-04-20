using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookRecommendation[] BookRecommendations => new BookRecommendation[]
        {
            new BookRecommendation { Id = new Guid(), Book = Books[0], RecommenderUser = Users[0], RecipientUser = Users[1] },
            new BookRecommendation { Id = new Guid(), Book = Books[1], RecommenderUser = Users[0], RecipientUser = Users[1] },
            new BookRecommendation { Id = new Guid(), Book = Books[2], RecommenderUser = Users[0], RecipientUser = Users[1] },
            new BookRecommendation { Id = new Guid(), Book = Books[3], RecommenderUser = Users[0], RecipientUser = Users[1] }
        };

        public static void SeedBookRecommendations(this ModelBuilder builder)
        {
            builder.Entity<BookRecommendation>().HasData(BookRecommendations);
        }
    }
}
