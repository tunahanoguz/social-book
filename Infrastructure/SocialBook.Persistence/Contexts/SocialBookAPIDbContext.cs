using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Communities;
using SocialBook.Domain.Entities.Identity;
using SocialBook.Domain.Entities.Users;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userRoles = new AppRole[]
            {
                new AppRole { Id = new Guid().ToString(), Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = new Guid().ToString(), Name = "Editor", NormalizedName = "EDITOR" }
            };

            builder.Entity<AppRole>().HasData(userRoles);

            var passwordHasher = new PasswordHasher<AppUser>();

            var users = new AppUser[]
            {
                new AppUser
                {
                    Id = new Guid().ToString(),
                    FirstName = "Tunahan",
                    LastName = "Oğuz",
                    Description = "Detail description about Tunahan Oğuz",
                    UserName = "tunahanoguz",
                    Email = "tunahanog@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(null, "Tunahan123--")
                },
                new AppUser
                {
                    Id = new Guid().ToString(),
                    FirstName = "John",
                    LastName = "Doe",
                    Description = "Detail description about John Doe",
                    UserName = "johndoe",
                    Email = "johndoe@examplemail.com",
                    PasswordHash = passwordHasher.HashPassword(null, "John123--")
                }
            };

            builder.Entity<AppUser>().HasData(users);

            var usersRoles = new AppUserRole[]
            {
                new AppUserRole { UserId = users[0].Id, RoleId = userRoles[0].Id },
                new AppUserRole { UserId = users[1].Id, RoleId = userRoles[1].Id }
            };

            builder.Entity<AppUserRole>().HasData(usersRoles);

            var genres = new Genre[]
            {
                new Genre
                {
                    Id = new Guid(),
                    Name = "Art",
                    MetaTitle = "Art",
                    MetaDescription = "Description for Art genre",
                    MetaKeywords = "art books, art genre books",
                    Slug = "art",
                    User = users[0]
                },
                new Genre
                {
                    Id = new Guid(),
                    Name = "Biography",
                    MetaTitle = "Biography",
                    MetaDescription = "Description for Biography genre",
                    MetaKeywords = "biography books, biography genre books",
                    Slug = "biography",
                    User = users[1]
                }
            };

            builder.Entity<Genre>().HasData(genres);

            var authors = new Author[]
            {
                new Author
                {
                    Id = new Guid(),
                    FirstName = "Charles",
                    LastName = "Dickens",
                    CountryOfBirth = "United Kingdom",
                    DateOfBirth = new DateTime(1812, 2, 7),
                    MetaTitle = "Charles Dickens",
                    MetaDescription = "Meta description for Charles Dickens",
                    MetaKeywords = "charles dickens, charles dickens author, charles dickens books",
                    Slug = "charles-dickens",
                    CreatorUser = users[0]
                },
                new Author
                {
                    Id = new Guid(),
                    FirstName = "Alexander",
                    LastName = "Pushkin",
                    CountryOfBirth = "Russia",
                    DateOfBirth = new DateTime(1799, 6, 6),
                    MetaTitle = "Alexander Pushkin",
                    MetaDescription = "Meta description for Alexander Pushkin",
                    MetaKeywords = "alexander pushkin, alexander pushkin author, alexander pushkin books",
                    Slug = "alexander-pushkin",
                    CreatorUser = users[1]
                }
            };

            builder.Entity<Author>().HasData(authors);
        }
    }
}
