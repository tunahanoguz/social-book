using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Common;

namespace SocialBook.Persistence.EntityConfigurations.Common
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"),
                    Name = "Novel",
                    MetaTitle = "Novel",
                    MetaDescription = "Description for Novel genre",
                    MetaKeywords = "novel books, novel genre books",
                    Slug = "novel",
                    UserId = new Guid("6b695933-0170-4908-a56c-25d5e5c2d005")
                }
            );
        }
    }
}
