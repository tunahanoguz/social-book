using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorReviewImageConfiguration : IEntityTypeConfiguration<AuthorReviewImage>
    {
        public void Configure(EntityTypeBuilder<AuthorReviewImage> builder)
        {
            builder.HasData(
                new AuthorReviewImage { Id = new Guid("980cdeab-feb0-4745-9635-8a2de36748b4"), FileName = "author-review-1", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46") },
                new AuthorReviewImage { Id = new Guid("ae4dc503-35ed-4972-877c-4bcafa33c2ee"), FileName = "author-review-2", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b") },
                new AuthorReviewImage { Id = new Guid("ee3bf8c4-f7da-45da-a529-e143bcc50529"), FileName = "author-review-3", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352") },
                new AuthorReviewImage { Id = new Guid("72e4f5f8-34cb-4e6a-aed2-f753f761e4d2"), FileName = "author-review-4", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa") },
                new AuthorReviewImage { Id = new Guid("9f1c778f-8c2f-414e-a34f-9ff2404e471b"), FileName = "author-review-5", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("19b469b0-1f15-463b-a13e-8a8797131f46") },
                new AuthorReviewImage { Id = new Guid("91dd28f8-9f44-4506-87ea-7eaf5926563b"), FileName = "author-review-6", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("9610f90d-7730-4960-a7bf-86676ab9976b") },
                new AuthorReviewImage { Id = new Guid("575755ba-b3c1-4d8a-a3bb-8dd31b1ef643"), FileName = "author-review-7", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352") },
                new AuthorReviewImage { Id = new Guid("c8fa489a-8de5-47ec-a8a8-aab76adb03b4"), FileName = "author-review-8", FileExtension = "png", FileSize = 32, AuthorReviewId = new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa") }
            );
        }
    }
}
