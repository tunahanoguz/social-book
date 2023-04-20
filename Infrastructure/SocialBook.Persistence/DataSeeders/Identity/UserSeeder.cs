using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static PasswordHasher<AppUser> _passwordHasher = new PasswordHasher<AppUser>();

        private static AppUser[] Users => new AppUser[]
        {
            new AppUser
            {
                Id = new Guid().ToString(),
                FirstName = "Tunahan",
                LastName = "Oğuz",
                Description = "Detail description about Tunahan Oğuz",
                UserName = "tunahanoguz",
                NormalizedUserName = "TUNAHANOGUZ",
                Email = "tunahanog@gmail.com",
                NormalizedEmail = "TUNAHANOG@GMAIL.COM",
                PasswordHash = _passwordHasher.HashPassword(null, "Tunahan123--")
            },
            new AppUser
            {
                Id = new Guid().ToString(),
                FirstName = "John",
                LastName = "Doe",
                Description = "Detail description about John Doe",
                UserName = "johndoe",
                NormalizedUserName = "JOHNDOE",
                Email = "johndoe@examplemail.com",
                NormalizedEmail = "JOHNDOE@EXAMPLEMAIL.COM",
                PasswordHash = _passwordHasher.HashPassword(null, "John123--")
            },
            new AppUser
            {
                Id = new Guid().ToString(),
                FirstName = "Jane",
                LastName = "Doe",
                Description = "Detail description about Jane Doe",
                UserName = "janedoe",
                NormalizedUserName = "JANEDOE",
                Email = "janedoe@examplemail.com",
                NormalizedEmail = "JANEDOE@EXAMPLEMAIL.COM",
                PasswordHash = _passwordHasher.HashPassword(null, "Jane123--")
            }
        };

        public static void SeedUsers(this ModelBuilder builder)
        {
            builder.Entity<AppUser>().HasData(Users);
        }
    }
}
