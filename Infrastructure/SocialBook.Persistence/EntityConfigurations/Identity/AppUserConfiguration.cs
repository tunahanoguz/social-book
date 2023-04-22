using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Persistence.EntityConfigurations.Identity
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();

            builder.HasData(
                new AppUser
                {
                    Id = "6b695933-0170-4908-a56c-25d5e5c2d005",
                    FirstName = "Tunahan",
                    LastName = "Oğuz",
                    Description = "Detail description about Tunahan Oğuz",
                    UserName = "tunahanoguz",
                    NormalizedUserName = "TUNAHANOGUZ",
                    Email = "tunahanog@gmail.com",
                    NormalizedEmail = "TUNAHANOG@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Tunahan123--")
                },
                new AppUser
                {
                    Id = "651e4582-f6e2-46b9-a4e4-8e8064e31ba3",
                    FirstName = "John",
                    LastName = "Doe",
                    Description = "Detail description about John Doe",
                    UserName = "johndoe",
                    NormalizedUserName = "JOHNDOE",
                    Email = "johndoe@examplemail.com",
                    NormalizedEmail = "JOHNDOE@EXAMPLEMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "John123--")
                },
                new AppUser
                {
                    Id = "92088e43-474e-4bd6-9dbe-cfc5293e885f",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Description = "Detail description about Jane Doe",
                    UserName = "janedoe",
                    NormalizedUserName = "JANEDOE",
                    Email = "janedoe@examplemail.com",
                    NormalizedEmail = "JANEDOE@EXAMPLEMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Jane123--")
                },
                new AppUser
                {
                    Id = "5088a487-2384-4eb6-ac10-eac5d24ee1d1",
                    FirstName = "James",
                    LastName = "Doe",
                    Description = "Detail description about James Doe",
                    UserName = "jamesdoe",
                    NormalizedUserName = "JAMESDOE",
                    Email = "jamesdoe@examplemail.com",
                    NormalizedEmail = "JAMESDOE@EXAMPLEMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "James123--")
                }
            );
        }
    }
}
