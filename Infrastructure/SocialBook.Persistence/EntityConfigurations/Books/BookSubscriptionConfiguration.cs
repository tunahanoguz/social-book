using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookSubscriptionConfiguration : IEntityTypeConfiguration<BookSubscription>
    {
        public void Configure(EntityTypeBuilder<BookSubscription> builder)
        {
            builder.HasData(
                new BookSubscription { Id = new Guid("b72f68db-eb98-44b4-ac7d-54b5451b8caf"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookSubscription { Id = new Guid("031d4502-71b5-47ec-a1c1-cb23565d5d41"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookSubscription { Id = new Guid("47a52949-a0d3-45d0-87fc-b6478b34e011"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookSubscription { Id = new Guid("773d7e0f-8ec0-4dde-928e-c60376c971c6"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
