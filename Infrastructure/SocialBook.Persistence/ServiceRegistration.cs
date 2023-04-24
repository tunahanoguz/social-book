using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Repositories.Books;
using SocialBook.Application.Repositories.Common;
using SocialBook.Application.Repositories.Communities;
using SocialBook.Application.Repositories.Users;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.EntityConfigurations;
using SocialBook.Persistence.Repositories.Authors;
using SocialBook.Persistence.Repositories.Books;
using SocialBook.Persistence.Repositories.Common;
using SocialBook.Persistence.Repositories.Communities;
using SocialBook.Persistence.Repositories.Users;

namespace SocialBook.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<SocialBookAPIDbContext>(options => options.UseNpgsql(Configuration.PostgreSQLConnectionString));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SocialBookAPIDbContext>();
            services.AddScoped<IEntityConfiguration, EntityConfiguration>();
            services.AddScoped<ISiteSettingReadRepository, SiteSettingReadRepository>();
            services.AddScoped<ISiteSettingWriteRepository, SiteSettingWriteRepository>();
            services.AddScoped<IGenreReadRepository, GenreReadRepository>();
            services.AddScoped<IGenreWriteRepository, GenreWriteRepository>();
            services.AddScoped<IBookReadRepository, BookReadRepository>();
            services.AddScoped<IBookWriteRepository, BookWriteRepository>();
            services.AddScoped<IBookGenreReadRepository, BookGenreReadRepository>();
            services.AddScoped<IBookGenreWriteRepository, BookGenreWriteRepository>();
            services.AddScoped<IBookImageReadRepository, BookImageReadRepository>();
            services.AddScoped<IBookImageWriteRepository, BookImageWriteRepository>();
            services.AddScoped<IBookRecommendationReadRepository, BookRecommendationReadRepository>();
            services.AddScoped<IBookRecommendationWriteRepository, BookRecommendationWriteRepository>();
            services.AddScoped<IBookReviewReadRepository, BookReviewReadRepository>();
            services.AddScoped<IBookReviewWriteRepository, BookReviewWriteRepository>();
            services.AddScoped<IBookReviewLikeReadRepository, BookReviewLikeReadRepository>();
            services.AddScoped<IBookReviewLikeWriteRepository, BookReviewLikeWriteRepository>();
            services.AddScoped<IBookReviewDislikeReadRepository, BookReviewDislikeReadRepository>();
            services.AddScoped<IBookReviewDislikeWriteRepository, BookReviewDislikeWriteRepository>();
            services.AddScoped<IBookReviewImageReadRepository, BookReviewImageReadRepository>();
            services.AddScoped<IBookReviewImageWriteRepository, BookReviewImageWriteRepository>();
            services.AddScoped<IBookSubscriptionReadRepository, BookSubscriptionReadRepository>();
            services.AddScoped<IBookSubscriptionWriteRepository, BookSubscriptionWriteRepository>();
            services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
            services.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
            services.AddScoped<IAuthorGenreReadRepository, AuthorGenreReadRepository>();
            services.AddScoped<IAuthorGenreWriteRepository, AuthorGenreWriteRepository>();
            services.AddScoped<IAuthorImageReadRepository, AuthorImageReadRepository>();
            services.AddScoped<IAuthorImageWriteRepository, AuthorImageWriteRepository>();
            services.AddScoped<IAuthorRecommendationReadRepository, AuthorRecommendationReadRepository>();
            services.AddScoped<IAuthorRecommendationWriteRepository, AuthorRecommendationWriteRepository>();
            services.AddScoped<IAuthorReviewReadRepository, AuthorReviewReadRepository>();
            services.AddScoped<IAuthorReviewWriteRepository, AuthorReviewWriteRepository>();
            services.AddScoped<IAuthorReviewLikeReadRepository, AuthorReviewLikeReadRepository>();
            services.AddScoped<IAuthorReviewLikeWriteRepository, AuthorReviewLikeWriteRepository>();
            services.AddScoped<IAuthorReviewDislikeReadRepository, AuthorReviewDislikeReadRepository>();
            services.AddScoped<IAuthorReviewDislikeWriteRepository, AuthorReviewDislikeWriteRepository>();
            services.AddScoped<IAuthorReviewImageReadRepository, AuthorReviewImageReadRepository>();
            services.AddScoped<IAuthorReviewImageWriteRepository, AuthorReviewImageWriteRepository>();
            services.AddScoped<IAuthorSubscriptionReadRepository, AuthorSubscriptionReadRepository>();
            services.AddScoped<IAuthorSubscriptionWriteRepository, AuthorSubscriptionWriteRepository>();
            services.AddScoped<ICommunityReadRepository, CommunityReadRepository>();
            services.AddScoped<ICommunityWriteRepository, CommunityWriteRepository>();
            services.AddScoped<ICommunityGenreReadRepository, CommunityGenreReadRepository>();
            services.AddScoped<ICommunityGenreWriteRepository, CommunityGenreWriteRepository>();
            services.AddScoped<ICommunityImageReadRepository, CommunityImageReadRepository>();
            services.AddScoped<ICommunityImageWriteRepository, CommunityImageWriteRepository>();
            services.AddScoped<ICommunityMemberReadRepository, CommunityMemberReadRepository>();
            services.AddScoped<ICommunityMemberWriteRepository, CommunityMemberWriteRepository>();
            services.AddScoped<ICommunityModeratorReadRepository, CommunityModeratorReadRepository>();
            services.AddScoped<ICommunityModeratorWriteRepository, CommunityModeratorWriteRepository>();
            services.AddScoped<ICommunityPostReadRepository, CommunityPostReadRepository>();
            services.AddScoped<ICommunityPostWriteRepository, CommunityPostWriteRepository>();
            services.AddScoped<ICommunityPostCommentReadRepository, CommunityPostCommentReadRepository>();
            services.AddScoped<ICommunityPostCommentWriteRepository, CommunityPostCommentWriteRepository>();
            services.AddScoped<ICommunityPostImageReadRepository, CommunityPostImageReadRepository>();
            services.AddScoped<ICommunityPostImageWriteRepository, CommunityPostImageWriteRepository>();
            services.AddScoped<IUserFavoriteBookReadRepository, UserFavoriteBookReadRepository>();
            services.AddScoped<IUserFavoriteBookWriteRepository, UserFavoriteBookWriteRepository>();
            services.AddScoped<IUserImageReadRepository, UserImageReadRepository>();
            services.AddScoped<IUserImageWriteRepository, UserImageWriteRepository>();
            services.AddScoped<IUserSocialMediaReadRepository, UserSocialMediaReadRepository>();
            services.AddScoped<IUserSocialMediaWriteRepository, UserSocialMediaWriteRepository>();
            services.AddScoped<IUserSocialMediaPlatformReadRepository, UserSocialMediaPlatformReadRepository>();
            services.AddScoped<IUserSocialMediaPlatformWriteRepository, UserSocialMediaPlatformWriteRepository>();
            services.AddScoped<IUserWantToReadBookReadRepository, UserWantToReadBookReadRepository>();
            services.AddScoped<IUserWantToReadBookWriteRepository, UserWantToReadBookWriteRepository>();
        }
    }
}
