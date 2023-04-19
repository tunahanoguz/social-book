using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static Book[] Books => new Book[]
        {
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
                CreatorUser = Users[0]
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
                CreatorUser = Users[1]
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
                CreatorUser = Users[0]
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
                CreatorUser = Users[1]
            }
        };

        public static void SeedBooks(this ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(Books);
        }
    }
}
