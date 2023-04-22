using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorReviewConfiguration : IEntityTypeConfiguration<AuthorReview>
    {
        public void Configure(EntityTypeBuilder<AuthorReview> builder)
        {
            builder.HasData(
                new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorReview { Id = new Guid(), Rating = 10, Comment = "A great author.", AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
