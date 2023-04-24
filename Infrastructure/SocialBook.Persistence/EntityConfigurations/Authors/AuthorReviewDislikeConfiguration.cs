using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorReviewDislikeConfiguration : IEntityTypeConfiguration<AuthorReviewDislike>
    {
        public void Configure(EntityTypeBuilder<AuthorReviewDislike> builder)
        {
            builder.HasData(
                new AuthorReviewDislike { Id = new Guid("7870185d-770e-44e7-adf7-d85d414ac245"), AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("cdd02a4a-943a-4f25-bb5e-233f25c311d5"), AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("85da9313-f6c0-46bc-bc53-9ec04c69345a"), AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("04042d77-6c7d-46d4-9b3f-0f3055aa3980"), AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("84fb6848-02e5-4dc1-b965-d9aba425faa6"), AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("bda2a640-089c-4931-99d3-04b7c8f93e93"), AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("8a356fd8-93c7-487b-bae5-f55600f93c77"), AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new AuthorReviewDislike { Id = new Guid("1a3176c0-af02-43c9-8fcc-7db5a7dd006e"), AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
