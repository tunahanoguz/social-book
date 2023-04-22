using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.EntityConfigurations.Authors;
using SocialBook.Persistence.EntityConfigurations.Books;
using SocialBook.Persistence.EntityConfigurations.Common;
using SocialBook.Persistence.EntityConfigurations.Communities;
using SocialBook.Persistence.EntityConfigurations.Identity;
using SocialBook.Persistence.EntityConfigurations.Users;

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
        public IEntityTypeConfiguration<BookReviewDislike> BookReviewDislikeConfiguration { get; set; } = new BookReviewDislikeConfiguration();
        public IEntityTypeConfiguration<BookReviewImage> BookReviewImageConfiguration { get; set; } = new BookReviewImageConfiguration();
        public IEntityTypeConfiguration<BookRecommendation> BookRecommendationConfiguration { get; set; } = new BookRecommendationConfiguration();
        public IEntityTypeConfiguration<BookSubscription> BookSubscriptionConfiguration { get; set; } = new BookSubscriptionConfiguration();
        public IEntityTypeConfiguration<UserFavoriteBook> UserFavoriteBookConfiguration { get; set; } = new UserFavoriteBookConfiguration();
        public IEntityTypeConfiguration<UserImage> UserImageConfiguration { get; set; } = new UserImageConfiguration();
        public IEntityTypeConfiguration<UserWantToReadBook> UserWantToReadBookConfiguration { get; set; } = new UserWantToReadBookConfiguration();
        public IEntityTypeConfiguration<UserSocialMediaPlatform> UserSocialMediaPlatformConfiguration { get; set; } = new UserSocialMediaPlatformConfiguration();
        public IEntityTypeConfiguration<UserSocialMedia> UserSocialMediaConfiguration { get; set; } = new UserSocialMediaConfiguration();
        public IEntityTypeConfiguration<Community> CommunityConfiguration { get; set; } = new CommunityConfiguration();
        public IEntityTypeConfiguration<CommunityImage> CommunityImageConfiguration { get; set; } = new CommunityImageConfiguration();
        public IEntityTypeConfiguration<CommunityGenre> CommunityGenreConfiguration { get; set; } = new CommunityGenreConfiguration();
        public IEntityTypeConfiguration<CommunityMember> CommunityMemberConfiguration { get; set; } = new CommunityMemberConfiguration();
        public IEntityTypeConfiguration<CommunityModerator> CommunityModeratorConfiguration { get; set; } = new CommunityModeratorConfiguration();
        public IEntityTypeConfiguration<CommunityPost> CommunityPostConfiguration { get; set; } = new CommunityPostConfiguration();
    }
}
