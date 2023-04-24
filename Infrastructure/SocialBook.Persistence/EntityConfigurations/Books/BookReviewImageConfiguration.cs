using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookReviewImageConfiguration : IEntityTypeConfiguration<BookReviewImage>
    {
        public void Configure(EntityTypeBuilder<BookReviewImage> builder)
        {
            builder.HasData(
                new BookReviewImage { Id = new Guid("d589fb1c-a72f-4084-8723-6df298faecf1"), FileName = "book-review-1", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("cea37e4a-392e-415e-9067-69993de3e509"), FileName = "book-review-2", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("e3b0a576-a011-452c-85c9-c99ce20cc224"), FileName = "book-review-3", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("ab0e24b6-9511-4605-b595-ab4f6777b377"), FileName = "book-review-4", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("2e2f7388-ada3-4b1d-9aaf-623325669e59"), FileName = "book-review-5", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("d307dc6b-2b0a-4416-8b87-8fd009829f78"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("cb5c9602-258f-4af7-9c84-d812d3513a55"), FileName = "book-review-6", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("40118223-c0b0-48c5-8de6-ef4a24b94951"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("43addc68-2a2b-4c97-a505-2c766c513057"), FileName = "book-review-7", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("61bb2e93-2110-4150-a93f-32603dd7f795"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookReviewImage { Id = new Guid("997adcd2-2a85-4588-801c-df9b67d9172c"), FileName = "book-review-8", FileExtension = "png", FileSize = 10, BookReviewId = new Guid("3bfc9cb2-68a5-4bb4-b100-9264e0aa2597"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
