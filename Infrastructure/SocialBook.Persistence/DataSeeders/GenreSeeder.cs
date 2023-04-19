using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Common;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static Genre[] Genres => new Genre[]
        {
            new Genre
                {
                    Id = new Guid(),
                    Name = "Art",
                    MetaTitle = "Art",
                    MetaDescription = "Description for Art genre",
                    MetaKeywords = "art books, art genre books",
                    Slug = "art",
                    User = Users[0]
                },
                new Genre
                {
                    Id = new Guid(),
                    Name = "Biography",
                    MetaTitle = "Biography",
                    MetaDescription = "Description for Biography genre",
                    MetaKeywords = "biography books, biography genre books",
                    Slug = "biography",
                    User = Users[1]
                }
        };

        public static void SeedGenres(this ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(Genres);
        }
    }
}
