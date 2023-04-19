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
                Name = "Novel",
                MetaTitle = "Novel",
                MetaDescription = "Description for Novel genre",
                MetaKeywords = "novel books, novel genre books",
                Slug = "novel",
                User = Users[0]
            }
        };

        public static void SeedGenres(this ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(Genres);
        }
    }
}
