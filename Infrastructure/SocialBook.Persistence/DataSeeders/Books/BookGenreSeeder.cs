using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookGenre[] BookGenres => new BookGenre[]
        {
            new BookGenre { Id = new Guid(), Book = Books[0], Genre = Genres[0] },
            new BookGenre { Id = new Guid(), Book = Books[0], Genre = Genres[1] },
            new BookGenre { Id = new Guid(), Book = Books[0], Genre = Genres[2] },
            new BookGenre { Id = new Guid(), Book = Books[0], Genre = Genres[3] }
        };

        public static void SeedBookGenres(this ModelBuilder builder)
        {
            builder.Entity<BookGenre>().HasData(BookGenres);
        }
    }
}
