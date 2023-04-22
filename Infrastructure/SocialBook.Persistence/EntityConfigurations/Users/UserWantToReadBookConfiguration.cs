using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations.Users
{
    public class UserWantToReadBookConfiguration : IEntityTypeConfiguration<UserWantToReadBook>
    {
        public void Configure(EntityTypeBuilder<UserWantToReadBook> builder)
        {
            builder.HasData(
                new UserWantToReadBook { Id = new Guid("08a144cc-33bd-402b-a432-efa4861ba8fd"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserWantToReadBook { Id = new Guid("9f7d6cdc-9117-4bdf-8a90-3c7b373baa87"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserWantToReadBook { Id = new Guid("f9ea7305-8c44-44cf-a584-4fe7cab5da77"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserWantToReadBook { Id = new Guid("661e4d02-226e-4ca5-bfee-869d37a387b2"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new UserWantToReadBook { Id = new Guid("08a144cc-33bd-402b-a432-efa4861ba8fd"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserWantToReadBook { Id = new Guid("9f7d6cdc-9117-4bdf-8a90-3c7b373baa87"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserWantToReadBook { Id = new Guid("f9ea7305-8c44-44cf-a584-4fe7cab5da77"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new UserWantToReadBook { Id = new Guid("661e4d02-226e-4ca5-bfee-869d37a387b2"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
