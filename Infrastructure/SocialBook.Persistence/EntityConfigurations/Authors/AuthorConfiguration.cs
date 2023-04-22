using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"),
                    FirstName = "Charles",
                    LastName = "Dickens",
                    CountryOfBirth = "United Kingdom",
                    DateOfBirth = new DateTime(1812, 2, 7),
                    MetaTitle = "Charles Dickens",
                    MetaDescription = "Meta description for Charles Dickens",
                    MetaKeywords = "charles dickens, charles dickens author, charles dickens books",
                    Slug = "charles-dickens",
                    CreatorUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f"
                },
                new Author
                {
                    Id = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"),
                    FirstName = "Alexander",
                    LastName = "Pushkin",
                    CountryOfBirth = "Russia",
                    DateOfBirth = new DateTime(1799, 6, 6),
                    MetaTitle = "Alexander Pushkin",
                    MetaDescription = "Meta description for Alexander Pushkin",
                    MetaKeywords = "alexander pushkin, alexander pushkin author, alexander pushkin books",
                    Slug = "alexander-pushkin",
                    CreatorUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1"
                }
            );
        }
    }
}
