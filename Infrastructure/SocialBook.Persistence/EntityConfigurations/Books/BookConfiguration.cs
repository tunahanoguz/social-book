using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = new Guid(),
                    Name = "A Tale of Two Cities",
                    Isbn = "9780141439600",
                    Description = "An awesome book",
                    PublishedYear = 1859,
                    PageCount = 489,
                    Language = "English",
                    MetaTitle = "A Tale of Two Cities",
                    MetaDescription = "An awesome book",
                    MetaKeywords = "a tale of two cities, charles dickens a tale of two cities",
                    Slug = "a-tale-of-two-cities",
                    CreatorUserId = "6b695933-0170-4908-a56c-25d5e5c2d005"
                },
                new Book
                {
                    Id = new Guid(),
                    Name = "Great Expectations",
                    Isbn = "9780192833594",
                    Description = "An awesome book",
                    PublishedYear = 1860,
                    PageCount = 544,
                    Language = "English",
                    MetaTitle = "Great Expectations",
                    MetaDescription = "An awesome book",
                    MetaKeywords = "great expectations, charles dickens great expectations",
                    Slug = "great-expectations",
                    CreatorUserId = "6b695933-0170-4908-a56c-25d5e5c2d005"
                },
                new Book
                {
                    Id = new Guid(),
                    Name = "The Captain's Daughter",
                    Isbn = "9781843911548",
                    Description = "An awesome book",
                    PublishedYear = 1836,
                    PageCount = 124,
                    Language = "Russian",
                    MetaTitle = "The Captain's Daughter",
                    MetaDescription = "An awesome book",
                    MetaKeywords = "the captains daughter, charles dickens the captains daughter",
                    Slug = "the-captains-daughter",
                    CreatorUserId = "651e4582-f6e2-46b9-a4e4-8e8064e31ba3"
                },
                new Book
                {
                    Id = new Guid(),
                    Name = "Eugene Onegin",
                    Isbn = "9780140448108",
                    Description = "An awesome book",
                    PublishedYear = 1825,
                    PageCount = 240,
                    Language = "Russian",
                    MetaTitle = "Eugene Onegin",
                    MetaDescription = "An awesome book",
                    MetaKeywords = "eugene onegin, charles dickens eugene onegin",
                    Slug = "eugene-onegin",
                    CreatorUserId = "651e4582-f6e2-46b9-a4e4-8e8064e31ba3"
                }
            );
        }
    }
}
