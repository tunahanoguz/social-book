using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static UserImage[] UserImages => new UserImage[]
        {
            new UserImage { Id = new Guid(), FileName = "user-profile-image-1", FileExtension = "png", FileSize = 10 },
            new UserImage { Id = new Guid(), FileName = "user-cover-image-1", FileExtension = "png", FileSize = 10 },
            new UserImage { Id = new Guid(), FileName = "user-profile-image-2", FileExtension = "png", FileSize = 10 },
            new UserImage { Id = new Guid(), FileName = "user-cover-image-2", FileExtension = "png", FileSize = 10 },
            new UserImage { Id = new Guid(), FileName = "user-profile-image-3", FileExtension = "png", FileSize = 10 },
            new UserImage { Id = new Guid(), FileName = "user-cover-image-3", FileExtension = "png", FileSize = 10 },
        };

        public static void SeedUserImages(this ModelBuilder builder)
        {
            builder.Entity<UserImage>().HasData(UserImages);
        }
    }
}
