using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookReviewLikeConfiguration : IEntityTypeConfiguration<BookReviewLike>
    {
        public void Configure(EntityTypeBuilder<BookReviewLike> builder)
        {
            builder.HasData(
                new BookReviewLike { Id = new Guid("719d667c-cb3b-4982-a01f-74796367bbeb"), BookReviewId = new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new BookReviewLike { Id = new Guid("d3a164c0-7e83-4543-acf1-bbf53f3f3dde"), BookReviewId = new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new BookReviewLike { Id = new Guid("f2babd38-bb12-4e6f-97ee-129d68b2221b"), BookReviewId = new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new BookReviewLike { Id = new Guid("92c638da-cb40-4080-9df8-9a272258c432"), BookReviewId = new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
            );
        }
    }
}
