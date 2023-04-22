using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Persistence.EntityConfigurations.Authors;
using SocialBook.Persistence.EntityConfigurations.Books;
using SocialBook.Persistence.EntityConfigurations.Common;
using SocialBook.Persistence.EntityConfigurations.Identity;

namespace SocialBook.Persistence.EntityConfigurations
{
    public class EntityConfiguration : IEntityConfiguration
    {
        public IEntityTypeConfiguration<AppUser> AppUserConfiguration { get; set; } = new AppUserConfiguration();
        public IEntityTypeConfiguration<AppRole> AppRoleConfiguration { get; set; } = new AppRoleConfiguration();
        public IEntityTypeConfiguration<AppUserRole> AppUserRoleConfiguration { get; set; } = new AppUserRoleConfiguration();
        public IEntityTypeConfiguration<SiteSetting> SiteSettingConfiguration { get; set; } = new SiteSettingConfiguration();
        public IEntityTypeConfiguration<Genre> GenreConfiguration { get; set; } = new GenreConfiguration();
        public IEntityTypeConfiguration<Author> AuthorConfiguration { get; set; } = new AuthorConfiguration();
        public IEntityTypeConfiguration<AuthorGenre> AuthorGenreConfiguration { get; set; } = new AuthorGenreConfiguration();
        public IEntityTypeConfiguration<AuthorImage> AuthorImageConfiguration { get; set; } = new AuthorImageConfiguration();
        public IEntityTypeConfiguration<AuthorReview> AuthorReviewConfiguration { get; set; } = new AuthorReviewConfiguration();
        public IEntityTypeConfiguration<AuthorReviewLike> AuthorReviewLikeConfiguration { get; set; } = new AuthorReviewLikeConfiguration();
        public IEntityTypeConfiguration<AuthorReviewDislike> AuthorReviewDislikeConfiguration { get; set; } = new AuthorReviewDislikeConfiguration();
        public IEntityTypeConfiguration<AuthorReviewImage> AuthorReviewImageConfiguration { get; set; } = new AuthorReviewImageConfiguration();
        public IEntityTypeConfiguration<AuthorRecommendation> AuthorRecommendationConfiguration { get; set; } = new AuthorRecommendationConfiguration();
        public IEntityTypeConfiguration<AuthorSubscription> AuthorSubscriptionConfiguration { get; set; } = new AuthorSubscriptionConfiguration();
        public IEntityTypeConfiguration<Book> BookConfiguration { get; set; } = new BookConfiguration();
        public IEntityTypeConfiguration<BookGenre> BookGenreConfiguration { get; set; } = new BookGenreConfiguration();
        public IEntityTypeConfiguration<BookImage> BookImageConfiguration { get; set; } = new BookImageConfiguration();
        public IEntityTypeConfiguration<BookReview> BookReviewConfiguration { get; set; } = new BookReviewConfiguration();
        public IEntityTypeConfiguration<BookReviewLike> BookReviewLikeConfiguration { get; set; } = new BookReviewLikeConfiguration();
    }
}
