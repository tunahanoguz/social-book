using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Domain.Entities.Users;

namespace SocialBook.Persistence.EntityConfigurations
{
    public interface IEntityConfiguration
    {
        IEntityTypeConfiguration<AppUser> AppUserConfiguration { get; set; }
        IEntityTypeConfiguration<AppRole> AppRoleConfiguration { get; set; }
        IEntityTypeConfiguration<AppUserRole> AppUserRoleConfiguration { get; set; }
        IEntityTypeConfiguration<SiteSetting> SiteSettingConfiguration { get; set; }
        IEntityTypeConfiguration<Genre> GenreConfiguration { get; set; }
        IEntityTypeConfiguration<Author> AuthorConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorGenre> AuthorGenreConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorImage> AuthorImageConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorReview> AuthorReviewConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorReviewLike> AuthorReviewLikeConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorReviewDislike> AuthorReviewDislikeConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorReviewImage> AuthorReviewImageConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorRecommendation> AuthorRecommendationConfiguration { get; set; }
        IEntityTypeConfiguration<AuthorSubscription> AuthorSubscriptionConfiguration { get; set; }
        IEntityTypeConfiguration<Book> BookConfiguration { get; set; }
        IEntityTypeConfiguration<BookGenre> BookGenreConfiguration { get; set; }
        IEntityTypeConfiguration<BookImage> BookImageConfiguration { get; set; }
        IEntityTypeConfiguration<BookReview> BookReviewConfiguration { get; set; }
        IEntityTypeConfiguration<BookReviewLike> BookReviewLikeConfiguration { get; set; }
        IEntityTypeConfiguration<BookReviewDislike> BookReviewDislikeConfiguration { get; set; }
        IEntityTypeConfiguration<BookReviewImage> BookReviewImageConfiguration { get; set; }
        IEntityTypeConfiguration<BookRecommendation> BookRecommendationConfiguration { get; set; }
        IEntityTypeConfiguration<BookSubscription> BookSubscriptionConfiguration { get; set; }
        IEntityTypeConfiguration<UserFavoriteBook> UserFavoriteBookConfiguration { get; set; }
        IEntityTypeConfiguration<UserImage> UserImageConfiguration { get; set; }
        IEntityTypeConfiguration<UserWantToReadBook> UserWantToReadBookConfiguration { get; set; }
        IEntityTypeConfiguration<UserSocialMediaPlatform> UserSocialMediaPlatformConfiguration { get; set; }
        IEntityTypeConfiguration<UserSocialMedia> UserSocialMediaConfiguration { get; set; }
        IEntityTypeConfiguration<Community> CommunityConfiguration { get; set; }
        IEntityTypeConfiguration<CommunityImage> CommunityImageConfiguration { get; set; }
    }
}
