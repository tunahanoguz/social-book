using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorGenre[] AuthorGenres => new AuthorGenre[]
        {
            new AuthorGenre { Id = new Guid(), Author = Authors[0], Genre = Genres[0] },
            new AuthorGenre { Id = new Guid(), Author = Authors[1], Genre = Genres[0] }
        };

        public static void SeedAuthorGenres(this ModelBuilder builder)
        {
            builder.Entity<AuthorGenre>().HasData(AuthorGenres);
        }
    }
}
