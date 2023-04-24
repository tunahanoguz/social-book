using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.HasData(
                new BookGenre { Id = new Guid("99de9db8-1832-4662-8916-1ebdf6b0c20b"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookGenre { Id = new Guid("8341330c-71ec-4952-ae01-1450e312382d"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookGenre { Id = new Guid("7fa98cfc-5d30-45dc-ad9c-d87cd3e7e938"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new BookGenre { Id = new Guid("85af484f-4e5d-42c1-9f3d-9eb2439b7f07"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
