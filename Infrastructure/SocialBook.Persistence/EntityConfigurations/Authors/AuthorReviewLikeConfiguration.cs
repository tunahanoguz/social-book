using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorReviewLikeConfiguration : IEntityTypeConfiguration<AuthorReviewLike>
    {
        public void Configure(EntityTypeBuilder<AuthorReviewLike> builder)
        {
            builder.HasData(
                new AuthorReviewLike { Id = new Guid("4c715b96-0f12-4646-9cb9-b8ee50aa39f3"), AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReviewLike { Id = new Guid("653f43f7-65e6-4955-9ca7-8ed441d83878"), AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReviewLike { Id = new Guid("6b1b7e40-163b-4e58-b570-1ad170e1373c"), AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReviewLike { Id = new Guid("60670cd3-859e-4c71-857c-f144265f984d"), AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new AuthorReviewLike { Id = new Guid("90bf2914-bb18-4be9-9350-cf5f8d226da1"), AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorReviewLike { Id = new Guid("5e6b7a54-eafd-41af-9ea7-38d5960f879c"), AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorReviewLike { Id = new Guid("ed5cab18-12cd-4ae8-a330-ec193e162492"), AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorReviewLike { Id = new Guid("69874936-13ff-4faf-8e04-c57be9dfbdf1"), AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
