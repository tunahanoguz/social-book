﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Domain.Entities.Users;
using SocialBook.Persistence.EntityConfigurations;

namespace SocialBook.Persistence.Contexts
{
    public class SocialBookAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IEntityConfiguration _entityConfiguration;

        public SocialBookAPIDbContext(DbContextOptions options, IEntityConfiguration entityConfiguration) : base(options)
        {
            _entityConfiguration = entityConfiguration;
        }

        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<BookRecommendation> BookRecommendations { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<BookReviewLike> BookReviewLikes { get; set; }
        public DbSet<BookReviewDislike> BookReviewDislikes { get; set; }
        public DbSet<BookReviewImage> BookReviewImages { get; set; }
        public DbSet<BookSubscription> BookSubscriptions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorGenre> AuthorGenres { get; set; }
        public DbSet<AuthorImage> AuthorImages { get; set; }
        public DbSet<AuthorRecommendation> AuthorRecommendations { get; set; }
        public DbSet<AuthorReview> AuthorReviews { get; set; }
        public DbSet<AuthorReviewLike> AuthorReviewLikes { get; set; }
        public DbSet<AuthorReviewDislike> AuthorReviewDislikes { get; set; }
        public DbSet<AuthorReviewImage> AuthorReviewImages { get; set; }
        public DbSet<AuthorSubscription> AuthorSubscriptions { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityGenre> CommunityGenres { get; set; }
        public DbSet<CommunityImage> CommunityImages { get; set; }
        public DbSet<CommunityMember> CommunityMembers { get; set; }
        public DbSet<CommunityModerator> CommunityModerators { get; set; }
        public DbSet<CommunityPost> CommunityPosts { get; set; }
        public DbSet<CommunityPostComment> CommunityPostComments { get; set; }
        public DbSet<CommunityPostImage> CommunityPostImages { get; set; }
        public DbSet<UserFavoriteBook> UserFavoriteBooks { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<UserSocialMedia> UserSocialMedias { get; set; }
        public DbSet<UserSocialMediaPlatform> UserSocialMediaPlatforms { get; set; }
        public DbSet<UserWantToReadBook> UserWantToReadBooks { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var data = ChangeTracker.Entries<BaseEntity>();

            foreach (var record in data)
            {
                if (record.State == EntityState.Added)
                    record.Entity.CreatedDate = DateTime.UtcNow;

                if (record.State == EntityState.Modified)
                    record.Entity.UpdatedDate = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(_entityConfiguration.AppUserConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AppRoleConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AppUserRoleConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.SiteSettingConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.GenreConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorGenreConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorReviewConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorReviewLikeConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorReviewDislikeConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorReviewImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorRecommendationConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.AuthorSubscriptionConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookGenreConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookReviewConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookReviewLikeConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookReviewImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookRecommendationConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.BookSubscriptionConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.UserFavoriteBookConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.UserImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.UserWantToReadBookConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.UserSocialMediaPlatformConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.UserSocialMediaConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityGenreConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityMemberConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityModeratorConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityPostConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityPostImageConfiguration);
            builder.ApplyConfiguration(_entityConfiguration.CommunityPostCommentConfiguration);
        }
    }
}
