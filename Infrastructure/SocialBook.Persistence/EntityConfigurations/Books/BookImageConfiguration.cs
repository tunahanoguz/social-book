using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
    {
        public void Configure(EntityTypeBuilder<BookImage> builder)
        {
            builder.HasData(
                new BookImage { Id = new Guid("1aea6cf4-e595-4b65-bd75-070a6ab52de0"), FileName = "book-image-1", FileExtension = "png", FileSize = 10, BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("804c8556-21c5-4289-ac1d-f37e4fdd8a48"), FileName = "book-image-2", FileExtension = "png", FileSize = 10, BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("7efc6b63-532e-4624-a700-19c2a37bec9e"), FileName = "book-image-3", FileExtension = "png", FileSize = 10, BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("0dcb946b-a1f2-446a-96d0-09ac8a63e4bf"), FileName = "book-image-4", FileExtension = "png", FileSize = 10, BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("43e56053-822d-498c-8364-5798495a29b6"), FileName = "book-image-5", FileExtension = "png", FileSize = 10, BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("6b760a1c-acc7-4512-9e57-defcdddcf56a"), FileName = "book-image-6", FileExtension = "png", FileSize = 10, BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("5f5940c0-292f-439c-9491-54d9091adee2"), FileName = "book-image-7", FileExtension = "png", FileSize = 10, BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookImage { Id = new Guid("1e6e9cdd-ba66-444b-9569-3d7a88e12c4e"), FileName = "book-image-8", FileExtension = "png", FileSize = 10, BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
