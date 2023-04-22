using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookReviewConfiguration : IEntityTypeConfiguration<BookReview>
    {
        public void Configure(EntityTypeBuilder<BookReview> builder)
        {
            builder.HasData(
                new BookReview { Id = new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), Rating = 10, Comment = "A great book.", BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new BookReview { Id = new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), Rating = 10, Comment = "A great book.", BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new BookReview { Id = new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), Rating = 10, Comment = "A great book.", BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new BookReview { Id = new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), Rating = 10, Comment = "A great book.", BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new BookReview { Id = new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), Rating = 10, Comment = "A great book.", BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new BookReview { Id = new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), Rating = 10, Comment = "A great book.", BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new BookReview { Id = new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), Rating = 10, Comment = "A great book.", BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new BookReview { Id = new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), Rating = 10, Comment = "A great book.", BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
