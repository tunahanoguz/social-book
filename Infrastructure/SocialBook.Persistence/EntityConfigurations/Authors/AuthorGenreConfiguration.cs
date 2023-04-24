using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorGenreConfiguration : IEntityTypeConfiguration<AuthorGenre>
    {
        public void Configure(EntityTypeBuilder<AuthorGenre> builder)
        {
            builder.HasData(
                new AuthorGenre { Id = new Guid("0c3cf4f4-66d8-4434-8793-754353a00253"), AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorGenre { Id = new Guid("08c6b198-c710-42b6-b237-9c3ed087bd3c"), AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
