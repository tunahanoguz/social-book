using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorImageConfiguration : IEntityTypeConfiguration<AuthorImage>
    {
        public void Configure(EntityTypeBuilder<AuthorImage> builder)
        {
            builder.HasData(
                new AuthorImage { Id = new Guid("6a899c34-e51e-443d-a315-959136f3e49b"), FileName = "charles-dickens-1", FileExtension = "png", FileSize = 10, AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorImage { Id = new Guid("89042067-f5d1-46d8-8661-bf68435a6375"), FileName = "charles-dickens-2", FileExtension = "png", FileSize = 10, AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorImage {Id = new Guid("695240a8-6ce5-4971-bd84-80a545c0f800"), FileName = "charles-dickens-3", FileExtension = "png", FileSize = 10, AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorImage { Id = new Guid("2de516cd-8f17-4cca-a9fe-145031916122"), FileName = "alexander-pushkin-1", FileExtension = "png", FileSize = 10, AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorImage {Id = new Guid("27e88da6-7be9-43ae-895e-b3e721c067a6"), FileName = "alexander-pushkin-2", FileExtension = "png", FileSize = 10, AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorImage {Id = new Guid("f3141743-ca7e-42d3-a95d-d038e1c1cfe6"), FileName = "alexander-pushkin-3", FileExtension = "png", FileSize = 10, AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
