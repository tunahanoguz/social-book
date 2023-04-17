﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Authors;
using SocialBook.Domain.Books;
using SocialBook.Domain.Common;
using SocialBook.Domain.Communities;
using SocialBook.Domain.Identity;
using SocialBook.Domain.Users;

namespace SocialBook.Persistence.Contexts
{
    public class SocialBookAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public SocialBookAPIDbContext(DbContextOptions options) : base(options)
        {
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

    }
}
