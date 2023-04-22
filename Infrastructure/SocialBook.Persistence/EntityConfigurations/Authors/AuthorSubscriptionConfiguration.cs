using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorSubscriptionConfiguration : IEntityTypeConfiguration<AuthorSubscription>
    {
        public void Configure(EntityTypeBuilder<AuthorSubscription> builder)
        {
            builder.HasData(
                new AuthorSubscription { Id = new Guid("cccdd851-d524-421d-9fee-35a62de5edd5"), AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorSubscription { Id = new Guid("dbbbbba3-4694-48c3-8717-a2b564615278"), AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorSubscription { Id = new Guid("4373c365-2753-4dbc-a143-49722b87525b"), AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorSubscription { Id = new Guid("665ec0ee-a754-4731-8f75-f82803663730"), AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
