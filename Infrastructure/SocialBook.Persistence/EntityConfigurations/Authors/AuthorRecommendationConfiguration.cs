using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.EntityConfigurations.Authors
{
    public class AuthorRecommendationConfiguration : IEntityTypeConfiguration<AuthorRecommendation>
    {
        public void Configure(EntityTypeBuilder<AuthorRecommendation> builder)
        {
            builder.HasData(
                new AuthorRecommendation() { Id = new Guid("6dafbff6-ebb1-483a-8461-8ab6e2ec78d3"), AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), RecommenderUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", RecipientUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new AuthorRecommendation() { Id = new Guid("84ab9e1f-0c20-4966-96a1-0a7f22f78ac9"), AuthorId = new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), RecommenderUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", RecipientUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
            );
        }
    }
}
