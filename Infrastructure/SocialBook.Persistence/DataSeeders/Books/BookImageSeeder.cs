using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static BookImage[] BookImages => new BookImage[]
        {
            new BookImage { Id = new Guid(), FileName = "book-image-1", FileExtension = "png", FileSize = 10, Book = Books[0] },
            new BookImage { Id = new Guid(), FileName = "book-image-2", FileExtension = "png", FileSize = 10, Book = Books[0] },
            new BookImage { Id = new Guid(), FileName = "book-image-3", FileExtension = "png", FileSize = 10, Book = Books[1] },
            new BookImage { Id = new Guid(), FileName = "book-image-4", FileExtension = "png", FileSize = 10, Book = Books[1] },
            new BookImage { Id = new Guid(), FileName = "book-image-5", FileExtension = "png", FileSize = 10, Book = Books[2] },
            new BookImage { Id = new Guid(), FileName = "book-image-6", FileExtension = "png", FileSize = 10, Book = Books[2] },
            new BookImage { Id = new Guid(), FileName = "book-image-7", FileExtension = "png", FileSize = 10, Book = Books[3] },
            new BookImage { Id = new Guid(), FileName = "book-image-8", FileExtension = "png", FileSize = 10, Book = Books[3] }
        };

        public static void SeedBookImages(this ModelBuilder builder)
        {
            builder.Entity<BookImage>().HasData(BookImages);
        }
    }
}
