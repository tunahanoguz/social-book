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
                new AuthorReview { Id = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), Rating = 10, Comment = "A great author.", AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorReview {Id = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), Rating = 10, Comment = "A great author.", AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorReview {Id = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), Rating = 10, Comment = "A great author.", AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new AuthorReview {Id = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), Rating = 10, Comment = "A great author.", AuthorId = new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
