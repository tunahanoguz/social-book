using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        public static Author[] Authors => new Author[]
        {
            new Author
            {
                Id = new Guid(),
                FirstName = "Charles",
                LastName = "Dickens",
                CountryOfBirth = "United Kingdom",
                DateOfBirth = new DateTime(1812, 2, 7),
                MetaTitle = "Charles Dickens",
                MetaDescription = "Meta description for Charles Dickens",
                MetaKeywords = "charles dickens, charles dickens author, charles dickens books",
                Slug = "charles-dickens",
                CreatorUser = Users[0]
            },
            new Author
            {
                Id = new Guid(),
                FirstName = "Alexander",
                LastName = "Pushkin",
                CountryOfBirth = "Russia",
                DateOfBirth = new DateTime(1799, 6, 6),
                MetaTitle = "Alexander Pushkin",
                MetaDescription = "Meta description for Alexander Pushkin",
                MetaKeywords = "alexander pushkin, alexander pushkin author, alexander pushkin books",
                Slug = "alexander-pushkin",
                CreatorUser = Users[1]
            }
        };

        public static void SeedAuthors(this ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(Authors);
        }
    }
}
