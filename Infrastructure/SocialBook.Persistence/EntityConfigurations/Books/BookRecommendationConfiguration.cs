using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Persistence.EntityConfigurations.Books
{
    public class BookRecommendationConfiguration : IEntityTypeConfiguration<BookRecommendation>
    {
        public void Configure(EntityTypeBuilder<BookRecommendation> builder)
        {
            builder.HasData(
                new BookRecommendation { Id = new Guid("055ba2bd-bfb9-49cc-af9b-ef9c6127b2cc"), BookId = new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), RecommenderUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", RecipientUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookRecommendation { Id = new Guid("9543d02d-0c6d-44cb-a841-d1b52e57fbab"), BookId = new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), RecommenderUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", RecipientUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookRecommendation { Id = new Guid("477a193b-2cd6-4b2b-801d-af3cb520f4b2"), BookId = new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), RecommenderUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", RecipientUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new BookRecommendation { Id = new Guid("a8b97ae1-9c4b-4460-b058-f0af716515b6"), BookId = new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), RecommenderUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", RecipientUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
