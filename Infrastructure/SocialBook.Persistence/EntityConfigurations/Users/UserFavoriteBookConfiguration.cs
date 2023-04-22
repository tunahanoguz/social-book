using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations.Users
{
    public class UserFavoriteBookConfiguration : IEntityTypeConfiguration<UserFavoriteBook>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteBook> builder)
        {
            builder.HasData(
                new UserFavoriteBook { Id = new Guid("908fa135-fa60-4564-83a9-ea8205249917"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserFavoriteBook { Id = new Guid("7116d650-b4f7-4256-987f-7aa3424143f8"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserFavoriteBook { Id = new Guid("e2e80d2a-1975-47b5-b32d-291f3da1fbf9"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserFavoriteBook { Id = new Guid("4a24b206-c433-4081-8688-6203af1b1558"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserFavoriteBook { Id = new Guid("3e41d3d6-da84-4a0c-90cb-1cb45216922b"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserFavoriteBook { Id = new Guid("5ac50b3f-4a34-4d92-ae31-d0c3049aab91"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserFavoriteBook { Id = new Guid("697d56ff-0099-4817-97bb-7437d2840d55"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserFavoriteBook { Id = new Guid("7201c06c-64a6-4ec4-bdc0-b419185885fa"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
