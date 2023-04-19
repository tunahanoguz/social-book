using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorImage[] AuthorImages => new AuthorImage[]
        {
            new AuthorImage { Id = new Guid(), FileName = "charles-dickens-1", FileExtension = "png", FileSize = 10, Author = Authors[0] },
            new AuthorImage { Id = new Guid(), FileName = "charles-dickens-2", FileExtension = "png", FileSize = 10, Author = Authors[0] },
            new AuthorImage { Id = new Guid(), FileName = "charles-dickens-3", FileExtension = "png", FileSize = 10, Author = Authors[0] },
            new AuthorImage { Id = new Guid(), FileName = "alexander-pushkin-1", FileExtension = "png", FileSize = 10, Author = Authors[1] },
            new AuthorImage { Id = new Guid(), FileName = "alexander-pushkin-2", FileExtension = "png", FileSize = 10, Author = Authors[1] },
            new AuthorImage { Id = new Guid(), FileName = "alexander-pushkin-3", FileExtension = "png", FileSize = 10, Author = Authors[1] },
        };

        public static void SeedAuthorImages(this ModelBuilder builder)
        {
            builder.Entity<AuthorImage>().HasData(AuthorImages);
        }
    }
}
