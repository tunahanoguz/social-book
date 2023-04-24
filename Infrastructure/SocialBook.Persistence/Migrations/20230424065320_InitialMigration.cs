using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SocialBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunityImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    MetaDescription = table.Column<string>(type: "text", nullable: true),
                    MetaKeywords = table.Column<string>(type: "text", nullable: true),
                    PageTitleSeperator = table.Column<string>(type: "text", nullable: true),
                    IsAllowedNewBook = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookReview = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookReviewLike = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookReviewDislike = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookRecommendation = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedBookSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewAuthor = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorReview = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorReviewLike = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorReviewDislike = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorRecommendation = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedAuthorSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewGenre = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewCommunity = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedCommunityProfileImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedCommunityCoverImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedCommunityMembership = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewCommunityModerator = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewCommunityPost = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewCommunityPostComment = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewUserRegistration = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedUserProfileImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedUserCoverImageUpload = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewUserFavoriteBook = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewUserWantToReadBook = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSocialMediaPlatforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UrlPrefix = table.Column<string>(type: "text", nullable: true),
                    UrlPostfix = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocialMediaPlatforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ProfileImageIdId = table.Column<Guid>(type: "uuid", nullable: true),
                    CoverImageIdId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_UserImages_CoverImageIdId",
                        column: x => x.CoverImageIdId,
                        principalTable: "UserImages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_UserImages_ProfileImageIdId",
                        column: x => x.ProfileImageIdId,
                        principalTable: "UserImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CountryOfBirth = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MetaTitle = table.Column<string>(type: "text", nullable: true),
                    MetaDescription = table.Column<string>(type: "text", nullable: true),
                    MetaKeywords = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    IsAllowedReview = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedRecommendation = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorUserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Isbn = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PublishedYear = table.Column<int>(type: "integer", nullable: false),
                    PageCount = table.Column<int>(type: "integer", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: true),
                    MetaTitle = table.Column<string>(type: "text", nullable: true),
                    MetaDescription = table.Column<string>(type: "text", nullable: true),
                    MetaKeywords = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    IsAllowedReview = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedRecommendation = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedSubscription = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorUserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsPrivate = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedMembership = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewModerator = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewPost = table.Column<bool>(type: "boolean", nullable: false),
                    IsAllowedNewPostComment = table.Column<bool>(type: "boolean", nullable: false),
                    ProfileImageId = table.Column<Guid>(type: "uuid", nullable: false),
                    CoverImageId = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerUserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_AspNetUsers_OwnerUserId",
                        column: x => x.OwnerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Communities_CommunityImages_CoverImageId",
                        column: x => x.CoverImageId,
                        principalTable: "CommunityImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Communities_CommunityImages_ProfileImageId",
                        column: x => x.ProfileImageId,
                        principalTable: "CommunityImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MetaTitle = table.Column<string>(type: "text", nullable: true),
                    MetaDescription = table.Column<string>(type: "text", nullable: true),
                    MetaKeywords = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSocialMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    SocialMediaPlatformId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSocialMedias_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSocialMedias_UserSocialMediaPlatforms_SocialMediaPlatfo~",
                        column: x => x.SocialMediaPlatformId,
                        principalTable: "UserSocialMediaPlatforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorImages_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorRecommendations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecommenderUserId = table.Column<string>(type: "text", nullable: true),
                    RecipientUserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorRecommendations_AspNetUsers_RecipientUserId",
                        column: x => x.RecipientUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorRecommendations_AspNetUsers_RecommenderUserId",
                        column: x => x.RecommenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorRecommendations_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorReviews_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorSubscriptions_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookImages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRecommendations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecommenderUserId = table.Column<string>(type: "text", nullable: true),
                    RecipientUserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookRecommendations_AspNetUsers_RecipientUserId",
                        column: x => x.RecipientUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookRecommendations_AspNetUsers_RecommenderUserId",
                        column: x => x.RecommenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookRecommendations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookReviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookSubscriptions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavoriteBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoriteBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFavoriteBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserFavoriteBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWantToReadBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWantToReadBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWantToReadBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserWantToReadBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityMembers_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityModerators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityModerators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityModerators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityModerators_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    CommunityId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityPosts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityPosts_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorGenres_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityGenres_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunityGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorReviewDislikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorReviewDislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorReviewDislikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorReviewDislikes_AuthorReviews_AuthorReviewId",
                        column: x => x.AuthorReviewId,
                        principalTable: "AuthorReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorReviewImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    AuthorReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorReviewImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorReviewImages_AuthorReviews_AuthorReviewId",
                        column: x => x.AuthorReviewId,
                        principalTable: "AuthorReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorReviewLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorReviewLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorReviewLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorReviewLikes_AuthorReviews_AuthorReviewId",
                        column: x => x.AuthorReviewId,
                        principalTable: "AuthorReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookReviewDislikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviewDislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReviewDislikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookReviewDislikes_BookReviews_BookReviewId",
                        column: x => x.BookReviewId,
                        principalTable: "BookReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookReviewImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    BookReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviewImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReviewImages_BookReviews_BookReviewId",
                        column: x => x.BookReviewId,
                        principalTable: "BookReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookReviewLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviewLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReviewLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookReviewLikes_BookReviews_BookReviewId",
                        column: x => x.BookReviewId,
                        principalTable: "BookReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPostComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: true),
                    CommunityPostId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityPostComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityPostComments_CommunityPostComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CommunityPostComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommunityPostComments_CommunityPosts_CommunityPostId",
                        column: x => x.CommunityPostId,
                        principalTable: "CommunityPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPostImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileExtension = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<double>(type: "double precision", nullable: false),
                    CommunityPostId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityPostImages_CommunityPosts_CommunityPostId",
                        column: x => x.CommunityPostId,
                        principalTable: "CommunityPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b35b86ea-8969-4121-8789-4d48b0cbab1a", "c1ae90c8-1357-4a0a-9942-27324f14f026", "Administrator", "ADMINISTRATOR" },
                    { "c8d734dd-3d51-41fa-b109-8672a30b183e", "753e0857-bd0c-4f14-a4b6-6ecab7ea124d", "Editor", "EDITOR" },
                    { "fbbfdce6-caa7-49ae-9118-13dc98d99600", "3c78d545-2f2d-479e-8106-368167d45e15", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CoverImageIdId", "Description", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageIdId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5088a487-2384-4eb6-ac10-eac5d24ee1d1", 0, "5d2663bd-72e1-4666-bb79-107e0b329664", null, "Detail description about James Doe", "jamesdoe@examplemail.com", true, "James", "Doe", false, null, "JAMESDOE@EXAMPLEMAIL.COM", "JAMESDOE", "AQAAAAEAACcQAAAAEJB6hCXpBiXFGZEMU0Et5JNxuMwWVae6il9tNlOuRd/AD/1qLm3E182eL3IlpSZi9A==", null, false, null, null, false, "jamesdoe" },
                    { "651e4582-f6e2-46b9-a4e4-8e8064e31ba3", 0, "55a7ca9a-c134-49bd-b9ed-6b3c46722058", null, "Detail description about John Doe", "johndoe@examplemail.com", true, "John", "Doe", false, null, "JOHNDOE@EXAMPLEMAIL.COM", "JOHNDOE", "AQAAAAEAACcQAAAAED0uim4iXo1Eb42/0UqpWsda3p5RZibNQm1SlJBygoOiXIq562qDzZzA/Yso3p8qFQ==", null, false, null, null, false, "johndoe" },
                    { "6b695933-0170-4908-a56c-25d5e5c2d005", 0, "477dd350-83e4-4b2f-9b98-a5f6a6e6a220", null, "Detail description about Tunahan Oğuz", "tunahanog@gmail.com", true, "Tunahan", "Oğuz", false, null, "TUNAHANOG@GMAIL.COM", "TUNAHANOGUZ", "AQAAAAEAACcQAAAAEEW9xjUNNi6THq3szliO/3UCneISPv1Z5q+H+olnoOz/79ofTi9BAP4UQ2Djo1RspA==", null, false, null, null, false, "tunahanoguz" },
                    { "92088e43-474e-4bd6-9dbe-cfc5293e885f", 0, "edd6d105-d8b5-4958-83fe-57ff7977d4c0", null, "Detail description about Jane Doe", "janedoe@examplemail.com", true, "Jane", "Doe", false, null, "JANEDOE@EXAMPLEMAIL.COM", "JANEDOE", "AQAAAAEAACcQAAAAEJCgiW0pD25e3Y/tBWpBoSq5DbEgs4nqgrQctLBmpTHIe2qOvPB1epU46b9FPZwhtw==", null, false, null, null, false, "janedoe" }
                });

            migrationBuilder.InsertData(
                table: "CommunityImages",
                columns: new[] { "Id", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e7ed195-1fb5-4a4a-94c9-36a421d52deb"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3053), "png", "community-profile-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3053) },
                    { new Guid("1309047f-eac7-4a9c-b731-b4379e01ddbe"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3054), "png", "community-profile-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3054) },
                    { new Guid("3550912e-f963-42f2-bdeb-f3f89736e67a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3062), "png", "community-cover-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3062) },
                    { new Guid("4b83ca08-b55c-4581-84d0-6daeeca8929a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3059), "png", "community-cover-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3059) },
                    { new Guid("669d1738-5abc-4d85-bf4d-3612975b8c75"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3056), "png", "community-profile-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3056) },
                    { new Guid("6e05c37a-c4da-4dd7-95d8-d78fc7bdd436"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3057), "png", "community-cover-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3057) },
                    { new Guid("9b52fb7d-99e3-49a1-8681-bc43a704e17e"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3060), "png", "community-cover-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3060) },
                    { new Guid("b477d72f-1f05-411c-8448-515e91dd75d8"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3051), "png", "community-profile-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3051) }
                });

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "Id", "CreatedDate", "IsAllowedAuthorImageUpload", "IsAllowedAuthorRecommendation", "IsAllowedAuthorReview", "IsAllowedAuthorReviewDislike", "IsAllowedAuthorReviewLike", "IsAllowedAuthorSubscription", "IsAllowedBookImageUpload", "IsAllowedBookRecommendation", "IsAllowedBookReview", "IsAllowedBookReviewDislike", "IsAllowedBookReviewLike", "IsAllowedBookSubscription", "IsAllowedCommunityCoverImageUpload", "IsAllowedCommunityMembership", "IsAllowedCommunityProfileImageUpload", "IsAllowedNewAuthor", "IsAllowedNewBook", "IsAllowedNewCommunity", "IsAllowedNewCommunityModerator", "IsAllowedNewCommunityPost", "IsAllowedNewCommunityPostComment", "IsAllowedNewGenre", "IsAllowedNewUserFavoriteBook", "IsAllowedNewUserRegistration", "IsAllowedNewUserWantToReadBook", "IsAllowedUserCoverImageUpload", "IsAllowedUserProfileImageUpload", "MetaDescription", "MetaKeywords", "PageTitleSeperator", "Title", "UpdatedDate" },
                values: new object[] { new Guid("43a2057c-6ed8-4c12-ad5d-1fdd37787296"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(487), true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, "Meta description for social book", "Meta keywords for social book", "-", "Social Book", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.InsertData(
                table: "UserImages",
                columns: new[] { "Id", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3912062f-391e-4536-9a7a-58d3267b4c4e"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2534), "png", "user-cover-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2534) },
                    { new Guid("677aa387-ec60-4995-9911-102d209fc199"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2538), "png", "user-profile-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2538) },
                    { new Guid("712af0fc-9685-4d0d-b227-b3b4b9f18bb5"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2535), "png", "user-profile-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2536) },
                    { new Guid("930e5e8f-f3d0-4b27-b357-109d610b5441"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2529), "png", "user-profile-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2529) },
                    { new Guid("c34a9c24-9062-4a60-a368-d6c404baaf4e"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2537), "png", "user-cover-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2537) },
                    { new Guid("c671e4d3-4f6d-40f9-ae24-cbde71b2a965"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2533), "png", "user-profile-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2533) },
                    { new Guid("ec4eec0a-9030-493d-9e9b-5b81a557eda3"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2531), "png", "user-cover-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2531) },
                    { new Guid("f37b2aa7-0c53-4b45-ad57-86c968d6ca51"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2540), "png", "user-cover-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2540) }
                });

            migrationBuilder.InsertData(
                table: "UserSocialMediaPlatforms",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate", "UrlPostfix", "UrlPrefix" },
                values: new object[,]
                {
                    { new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2710), "Twitter", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2710), null, "https://twitter.com/" },
                    { new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2711), "Instagram", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2711), null, "https://www.instagram.com/" },
                    { new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2708), "Facebook", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2708), null, "https://www.facebook.com/" },
                    { new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2712), "LinkedIn", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2713), null, "https://www.linkedin.com/in/" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "fbbfdce6-caa7-49ae-9118-13dc98d99600", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "AppUserRole" },
                    { "c8d734dd-3d51-41fa-b109-8672a30b183e", "651e4582-f6e2-46b9-a4e4-8e8064e31ba3", "AppUserRole" },
                    { "b35b86ea-8969-4121-8789-4d48b0cbab1a", "6b695933-0170-4908-a56c-25d5e5c2d005", "AppUserRole" },
                    { "fbbfdce6-caa7-49ae-9118-13dc98d99600", "92088e43-474e-4bd6-9dbe-cfc5293e885f", "AppUserRole" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CountryOfBirth", "CreatedDate", "CreatorUserId", "DateOfBirth", "Description", "FirstName", "IsAllowedRecommendation", "IsAllowedReview", "IsAllowedSubscription", "LastName", "MetaDescription", "MetaKeywords", "MetaTitle", "Slug", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), "United Kingdom", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(687), "92088e43-474e-4bd6-9dbe-cfc5293e885f", new DateTime(1812, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", false, false, false, "Dickens", "Meta description for Charles Dickens", "charles dickens, charles dickens author, charles dickens books", "Charles Dickens", "charles-dickens", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(687) },
                    { new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), "Russia", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(690), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new DateTime(1799, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexander", false, false, false, "Pushkin", "Meta description for Alexander Pushkin", "alexander pushkin, alexander pushkin author, alexander pushkin books", "Alexander Pushkin", "alexander-pushkin", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(691) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "CreatorUserId", "Description", "IsAllowedRecommendation", "IsAllowedReview", "IsAllowedSubscription", "Isbn", "Language", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "PageCount", "PublishedYear", "Slug", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b695933-0170-4908-a56c-25d5e5c2d005", "An awesome book", true, true, true, "9780141439600", "English", "An awesome book", "a tale of two cities, charles dickens a tale of two cities", "A Tale of Two Cities", "A Tale of Two Cities", 489, 1859, "a-tale-of-two-cities", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b695933-0170-4908-a56c-25d5e5c2d005", "An awesome book", true, true, true, "9780192833594", "English", "An awesome book", "great expectations, charles dickens great expectations", "Great Expectations", "Great Expectations", 544, 1860, "great-expectations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "651e4582-f6e2-46b9-a4e4-8e8064e31ba3", "An awesome book", true, true, true, "9781843911548", "Russian", "An awesome book", "the captains daughter, charles dickens the captains daughter", "The Captain's Daughter", "The Captain's Daughter", 124, 1836, "the-captains-daughter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1581), "651e4582-f6e2-46b9-a4e4-8e8064e31ba3", "An awesome book", true, true, true, "9780140448108", "Russian", "An awesome book", "eugene onegin, charles dickens eugene onegin", "Eugene Onegin", "Eugene Onegin", 240, 1825, "eugene-onegin", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1581) }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "CoverImageId", "CreatedDate", "Description", "IsAllowedMembership", "IsAllowedNewModerator", "IsAllowedNewPost", "IsAllowedNewPostComment", "IsPrivate", "Name", "OwnerUserId", "ProfileImageId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new Guid("6e05c37a-c4da-4dd7-95d8-d78fc7bdd436"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2902), "Community 1 description.", true, true, true, true, false, "Community 1", "92088e43-474e-4bd6-9dbe-cfc5293e885f", new Guid("b477d72f-1f05-411c-8448-515e91dd75d8"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2903) },
                    { new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new Guid("4b83ca08-b55c-4581-84d0-6daeeca8929a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2906), "Community 2 description.", true, true, true, true, false, "Community 2", "92088e43-474e-4bd6-9dbe-cfc5293e885f", new Guid("0e7ed195-1fb5-4a4a-94c9-36a421d52deb"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2906) },
                    { new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new Guid("9b52fb7d-99e3-49a1-8681-bc43a704e17e"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2908), "Community 3 description.", true, true, true, true, false, "Community 3", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new Guid("1309047f-eac7-4a9c-b731-b4379e01ddbe"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2908) },
                    { new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new Guid("3550912e-f963-42f2-bdeb-f3f89736e67a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2911), "Community 4 description.", true, true, true, true, false, "Community 4", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new Guid("669d1738-5abc-4d85-bf4d-3612975b8c75"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2911) }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "Slug", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(596), "Description for Novel genre", "novel books, novel genre books", "Novel", "Novel", "novel", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(597), "6b695933-0170-4908-a56c-25d5e5c2d005" });

            migrationBuilder.InsertData(
                table: "UserSocialMedias",
                columns: new[] { "Id", "CreatedDate", "SocialMediaPlatformId", "UpdatedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("02f57587-4eac-4399-86cc-49c495e6ed9f"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2802), new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2802), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "username" },
                    { new Guid("0503a657-f0e1-4d9c-8522-62f2dab9c121"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2796), new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2796), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "username" },
                    { new Guid("1dbb185f-30bc-4296-89c6-7cddc4340129"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2794), new Guid("a1601427-d8bf-4b12-9e2c-00919aeb7a76"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2794), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "username" },
                    { new Guid("276a6ac7-5724-4711-916c-3b0dacda1523"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2798), new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2798), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "username" },
                    { new Guid("3993af16-4d0b-4480-97a7-2da2a24974b4"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2787), new Guid("3c6fe1ee-1137-4392-862c-5f466d823b80"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2788), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "username" },
                    { new Guid("7003b4a6-709b-4e5c-a979-fc15e6452f65"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2790), new Guid("0abccc55-768d-4e77-a25a-fe4123fb891a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2790), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "username" },
                    { new Guid("710d7b9d-34d5-4354-a392-cab90cf6ef52"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2800), new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2800), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "username" },
                    { new Guid("e0550f6f-8dd1-4b44-b498-3cce15389b65"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2792), new Guid("1d99e05a-498d-4fcd-88a6-653751a7c46a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2792), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "username" }
                });

            migrationBuilder.InsertData(
                table: "AuthorGenres",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "GenreId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("08c6b198-c710-42b6-b237-9c3ed087bd3c"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(779), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(779) },
                    { new Guid("0c3cf4f4-66d8-4434-8793-754353a00253"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(775), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(776) }
                });

            migrationBuilder.InsertData(
                table: "AuthorImages",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("27e88da6-7be9-43ae-895e-b3e721c067a6"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(875), "png", "alexander-pushkin-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(876) },
                    { new Guid("2de516cd-8f17-4cca-a9fe-145031916122"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(874), "png", "alexander-pushkin-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(874) },
                    { new Guid("695240a8-6ce5-4971-bd84-80a545c0f800"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(872), "png", "charles-dickens-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(872) },
                    { new Guid("6a899c34-e51e-443d-a315-959136f3e49b"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(866), "png", "charles-dickens-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(866) },
                    { new Guid("89042067-f5d1-46d8-8661-bf68435a6375"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(869), "png", "charles-dickens-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(870) },
                    { new Guid("f3141743-ca7e-42d3-a95d-d038e1c1cfe6"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(877), "png", "alexander-pushkin-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(878) }
                });

            migrationBuilder.InsertData(
                table: "AuthorRecommendations",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "RecipientUserId", "RecommenderUserId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6dafbff6-ebb1-483a-8461-8ab6e2ec78d3"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1396), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "92088e43-474e-4bd6-9dbe-cfc5293e885f", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1397) },
                    { new Guid("84ab9e1f-0c20-4966-96a1-0a7f22f78ac9"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1399), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1399) }
                });

            migrationBuilder.InsertData(
                table: "AuthorReviews",
                columns: new[] { "Id", "AuthorId", "Comment", "CreatedDate", "Rating", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), "A great author.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(962), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(962), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), "A great author.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(964), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(964), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), "A great author.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(966), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(966), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), "A great author.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(968), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(968), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "AuthorSubscriptions",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("4373c365-2753-4dbc-a143-49722b87525b"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1493), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1493), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("665ec0ee-a754-4731-8f75-f82803663730"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1495), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1495), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("cccdd851-d524-421d-9fee-35a62de5edd5"), new Guid("2823add5-60f3-4272-9ec1-087d69cca72c"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1488), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1489), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("dbbbbba3-4694-48c3-8717-a2b564615278"), new Guid("6729df32-c197-4b42-8b58-d88e1c202346"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1491), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1491), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "Id", "BookId", "CreatedDate", "GenreId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7fa98cfc-5d30-45dc-ad9c-d87cd3e7e938"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1656), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1656) },
                    { new Guid("8341330c-71ec-4952-ae01-1450e312382d"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1653), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1654) },
                    { new Guid("85af484f-4e5d-42c1-9f3d-9eb2439b7f07"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1658), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1659) },
                    { new Guid("99de9db8-1832-4662-8916-1ebdf6b0c20b"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1650), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1650) }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0dcb946b-a1f2-446a-96d0-09ac8a63e4bf"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1742), "png", "book-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1742) },
                    { new Guid("1aea6cf4-e595-4b65-bd75-070a6ab52de0"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1735), "png", "book-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1735) },
                    { new Guid("1e6e9cdd-ba66-444b-9569-3d7a88e12c4e"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1751), "png", "book-image-8", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1751) },
                    { new Guid("43e56053-822d-498c-8364-5798495a29b6"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1744), "png", "book-image-5", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1744) },
                    { new Guid("5f5940c0-292f-439c-9491-54d9091adee2"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1749), "png", "book-image-7", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1749) },
                    { new Guid("6b760a1c-acc7-4512-9e57-defcdddcf56a"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1746), "png", "book-image-6", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1746) },
                    { new Guid("7efc6b63-532e-4624-a700-19c2a37bec9e"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1739), "png", "book-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1740) },
                    { new Guid("804c8556-21c5-4289-ac1d-f37e4fdd8a48"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1737), "png", "book-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1738) }
                });

            migrationBuilder.InsertData(
                table: "BookRecommendations",
                columns: new[] { "Id", "BookId", "CreatedDate", "RecipientUserId", "RecommenderUserId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("055ba2bd-bfb9-49cc-af9b-ef9c6127b2cc"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2191), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "92088e43-474e-4bd6-9dbe-cfc5293e885f", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2192) },
                    { new Guid("477a193b-2cd6-4b2b-801d-af3cb520f4b2"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2196), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2196) },
                    { new Guid("9543d02d-0c6d-44cb-a841-d1b52e57fbab"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2194), "5088a487-2384-4eb6-ac10-eac5d24ee1d1", "92088e43-474e-4bd6-9dbe-cfc5293e885f", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2194) },
                    { new Guid("a8b97ae1-9c4b-4460-b058-f0af716515b6"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2198), "92088e43-474e-4bd6-9dbe-cfc5293e885f", "5088a487-2384-4eb6-ac10-eac5d24ee1d1", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2198) }
                });

            migrationBuilder.InsertData(
                table: "BookReviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "Rating", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1892), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1892), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1890), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1890), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1887), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1888), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("3bfc9cb2-68a5-4bb4-b100-9264e0aa2597"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1902), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1902), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("40118223-c0b0-48c5-8de6-ef4a24b94951"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1898), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1898), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("61bb2e93-2110-4150-a93f-32603dd7f795"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1900), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1900), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1894), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1894), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("d307dc6b-2b0a-4416-8b87-8fd009829f78"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), "A great book.", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1896), 10, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1896), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "BookSubscriptions",
                columns: new[] { "Id", "BookId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("031d4502-71b5-47ec-a1c1-cb23565d5d41"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2342), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2342), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("47a52949-a0d3-45d0-87fc-b6478b34e011"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2345), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2346), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("773d7e0f-8ec0-4dde-928e-c60376c971c6"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2348), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2348), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("b72f68db-eb98-44b4-ac7d-54b5451b8caf"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2339), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2340), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "CommunityGenres",
                columns: new[] { "Id", "CommunityId", "CreatedDate", "GenreId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("37e166bd-20e4-4f13-9e1e-9d99e2f51dc5"), new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3195), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3195) },
                    { new Guid("4cd330fc-4cb6-4f88-8d11-2fcf2ad64c51"), new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3187), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3188) },
                    { new Guid("6f6f8c2e-f74d-4004-b6d1-a884244d5484"), new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3192), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3192) },
                    { new Guid("ae83a1e3-3e8e-42aa-9c9c-bfba97e831c6"), new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3190), new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3190) }
                });

            migrationBuilder.InsertData(
                table: "CommunityMembers",
                columns: new[] { "Id", "CommunityId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("3782e0c5-0090-4484-929c-11bdf47c522e"), new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3306), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3306), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("3d9f273c-bfaf-42f6-bd97-f2a4d9c767cf"), new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3308), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3308), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("6d4928c5-8c4d-48fa-9777-3db1b44e8e01"), new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3317), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3317), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("82fc9a4c-2ea2-47b6-97a5-a5f1220543fb"), new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3313), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3313), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("a7e231c7-6a28-4856-94c7-32e0f0860fe9"), new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3302), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("b2b072aa-a986-4feb-854c-72aa01a4f2e0"), new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3311), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("caec6866-b558-44a9-aebf-70db6c30cc54"), new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3315), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3315), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("ed904104-fa07-4975-82fe-57679219a269"), new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3304), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "CommunityModerators",
                columns: new[] { "Id", "CommunityId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("37e00050-2b58-458c-95db-d40a43cab9b9"), new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3425), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("7fc3ac04-6250-4791-a6e8-7bf7ff8f572a"), new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3433), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("8d18b441-2b18-444b-aba5-7cd51abe0ab8"), new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3437), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("91a7a0d6-d4d6-4770-accc-1e72ab0e040f"), new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3429), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3429), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("bc5ab8e2-63e1-4123-b9c9-80b8614385ce"), new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3435), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3435), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("c1463b4c-74a8-4478-94ed-3c37dec91184"), new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3431), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3431), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("d9247cb7-dd6d-4869-a3a5-b9fdbd093af3"), new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3427), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3427), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("f9bdb36e-39cc-4dfd-ae7f-7a9ab4cace6c"), new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3423), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "CommunityPosts",
                columns: new[] { "Id", "Body", "CommunityId", "CreatedDate", "Title", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8"), "Community Post 7 body.", new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3539), "Community Post 7", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3539), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1"), "Community Post 8 body.", new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3541), "Community Post 8", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3541), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("27e480c1-d49a-4e67-996c-1410ad424758"), "Community Post 2 body.", new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3525), "Community Post 2", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3525), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb"), "Community Post 3 body.", new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3529), "Community Post 3", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3529), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0"), "Community Post 4 body.", new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3531), "Community Post 4", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3532), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461"), "Community Post 1 body.", new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3522), "Community Post 1", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3522), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("d3132383-9763-427a-9079-fd57b46fbf56"), "Community Post 5 body.", new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3534), "Community Post 5", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3534), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619"), "Community Post 6 body.", new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3537), "Community Post 6", new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3537), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "UserFavoriteBooks",
                columns: new[] { "Id", "BookId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("3e41d3d6-da84-4a0c-90cb-1cb45216922b"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2446), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2446), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("4a24b206-c433-4081-8688-6203af1b1558"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2444), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2444), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("5ac50b3f-4a34-4d92-ae31-d0c3049aab91"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2448), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2448), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("697d56ff-0099-4817-97bb-7437d2840d55"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2450), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2450), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("7116d650-b4f7-4256-987f-7aa3424143f8"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2440), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("7201c06c-64a6-4ec4-bdc0-b419185885fa"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2453), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2453), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("908fa135-fa60-4564-83a9-ea8205249917"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2437), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2438), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("e2e80d2a-1975-47b5-b32d-291f3da1fbf9"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2442), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2442), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "UserWantToReadBooks",
                columns: new[] { "Id", "BookId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("08a144cc-33bd-402b-a432-efa4861ba8fd"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2619), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2620), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("3a6e4f67-1a80-4835-8638-f7e9592c5a74"), new Guid("3729783e-35d2-4860-9f4c-94220e96b158"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2629), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2629), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("43e94dba-1c13-4281-b456-ff12a156f1ce"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2631), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("661e4d02-226e-4ca5-bfee-869d37a387b2"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2627), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2627), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("9f7d6cdc-9117-4bdf-8a90-3c7b373baa87"), new Guid("5315b270-7da8-4e78-b3f6-ce402dbe7ac2"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2622), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2623), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("c34d2ff1-a1a1-4268-8de8-fd84113d2b1e"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2632), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2632), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("f9ea7305-8c44-44cf-a584-4fe7cab5da77"), new Guid("79adb4fd-b77d-4595-9227-48b9e48e7465"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2624), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2625), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("ffb40507-5cd9-4c6a-b2d4-dad8919292a4"), new Guid("9c8cb817-4155-48a1-8124-30a989af0d40"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2634), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2634), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "AuthorReviewDislikes",
                columns: new[] { "Id", "AuthorReviewId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("04042d77-6c7d-46d4-9b3f-0f3055aa3980"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1147), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1147), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("1a3176c0-af02-43c9-8fcc-7db5a7dd006e"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1155), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1155), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("7870185d-770e-44e7-adf7-d85d414ac245"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1140), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("84fb6848-02e5-4dc1-b965-d9aba425faa6"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1149), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("85da9313-f6c0-46bc-bc53-9ec04c69345a"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1145), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1145), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("8a356fd8-93c7-487b-bae5-f55600f93c77"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1153), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1153), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("bda2a640-089c-4931-99d3-04b7c8f93e93"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1151), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1151), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("cdd02a4a-943a-4f25-bb5e-233f25c311d5"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1143), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "AuthorReviewImages",
                columns: new[] { "Id", "AuthorReviewId", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("575755ba-b3c1-4d8a-a3bb-8dd31b1ef643"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1266), "png", "author-review-7", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1266) },
                    { new Guid("72e4f5f8-34cb-4e6a-aed2-f753f761e4d2"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1260), "png", "author-review-4", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1260) },
                    { new Guid("91dd28f8-9f44-4506-87ea-7eaf5926563b"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1264), "png", "author-review-6", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1264) },
                    { new Guid("980cdeab-feb0-4745-9635-8a2de36748b4"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1253), "png", "author-review-1", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1253) },
                    { new Guid("9f1c778f-8c2f-414e-a34f-9ff2404e471b"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1262), "png", "author-review-5", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1262) },
                    { new Guid("ae4dc503-35ed-4972-877c-4bcafa33c2ee"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1256), "png", "author-review-2", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1256) },
                    { new Guid("c8fa489a-8de5-47ec-a8a8-aab76adb03b4"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1268), "png", "author-review-8", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1268) },
                    { new Guid("ee3bf8c4-f7da-45da-a529-e143bcc50529"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1258), "png", "author-review-3", 32.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1258) }
                });

            migrationBuilder.InsertData(
                table: "AuthorReviewLikes",
                columns: new[] { "Id", "AuthorReviewId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c715b96-0f12-4646-9cb9-b8ee50aa39f3"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1046), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("5e6b7a54-eafd-41af-9ea7-38d5960f879c"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1056), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1056), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("60670cd3-859e-4c71-857c-f144265f984d"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1052), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1052), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("653f43f7-65e6-4955-9ca7-8ed441d83878"), new Guid("9610f90d-7730-4960-a7bf-86676ab9976b"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1048), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("69874936-13ff-4faf-8e04-c57be9dfbdf1"), new Guid("ccf45efe-6373-4a75-aa79-ac96c171d4fa"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1059), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1060), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("6b1b7e40-163b-4e58-b570-1ad170e1373c"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1050), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1050), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("90bf2914-bb18-4be9-9350-cf5f8d226da1"), new Guid("19b469b0-1f15-463b-a13e-8a8797131f46"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1054), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1054), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("ed5cab18-12cd-4ae8-a330-ec193e162492"), new Guid("be5510ac-4df2-4a67-b1c2-94cee91d4352"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1058), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "BookReviewImages",
                columns: new[] { "Id", "BookReviewId", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2e2f7388-ada3-4b1d-9aaf-623325669e59"), new Guid("d307dc6b-2b0a-4416-8b87-8fd009829f78"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2080), "png", "book-review-5", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2080) },
                    { new Guid("43addc68-2a2b-4c97-a505-2c766c513057"), new Guid("61bb2e93-2110-4150-a93f-32603dd7f795"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2084), "png", "book-review-7", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2084) },
                    { new Guid("997adcd2-2a85-4588-801c-df9b67d9172c"), new Guid("3bfc9cb2-68a5-4bb4-b100-9264e0aa2597"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2086), "png", "book-review-8", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2086) },
                    { new Guid("ab0e24b6-9511-4605-b595-ab4f6777b377"), new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2078), "png", "book-review-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2078) },
                    { new Guid("cb5c9602-258f-4af7-9c84-d812d3513a55"), new Guid("40118223-c0b0-48c5-8de6-ef4a24b94951"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2082), "png", "book-review-6", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2082) },
                    { new Guid("cea37e4a-392e-415e-9067-69993de3e509"), new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2074), "png", "book-review-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2074) },
                    { new Guid("d589fb1c-a72f-4084-8723-6df298faecf1"), new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2071), "png", "book-review-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2071) },
                    { new Guid("e3b0a576-a011-452c-85c9-c99ce20cc224"), new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2076), "png", "book-review-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(2076) }
                });

            migrationBuilder.InsertData(
                table: "BookReviewLikes",
                columns: new[] { "Id", "BookReviewId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("719d667c-cb3b-4982-a01f-74796367bbeb"), new Guid("383c4ba8-a1fa-4d2d-97b4-6eb255bc08f6"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1986), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1987), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("92c638da-cb40-4080-9df8-9a272258c432"), new Guid("bdd0da86-7a78-41a0-81b6-f2e3115310b1"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1993), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1993), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("d3a164c0-7e83-4543-acf1-bbf53f3f3dde"), new Guid("202757b2-728d-4895-80c1-8b336e55b1d5"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1989), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1989), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("f2babd38-bb12-4e6f-97ee-129d68b2221b"), new Guid("0d15b45f-da86-46c4-ba5b-4761ce042aa4"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(1991), "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
                });

            migrationBuilder.InsertData(
                table: "CommunityPostComments",
                columns: new[] { "Id", "Body", "CommunityPostId", "CreatedDate", "ParentCommentId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("190fee70-14a5-418d-8bce-3bf9c27a9d91"), "Community post comment body.", new Guid("27e480c1-d49a-4e67-996c-1410ad424758"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3719), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3719), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("45bb9ccc-912e-4c6d-9a99-83ec7629916c"), "Community post comment body.", new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3727), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3727), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("4f36a23d-df41-4519-b0b1-4312f34da98c"), "Community post comment body.", new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3721), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3721), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("565171d5-f12f-4598-9444-681076032301"), "Community post comment body.", new Guid("d3132383-9763-427a-9079-fd57b46fbf56"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3725), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3725), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("66e8ad10-d833-459f-818e-29fbf306a2ec"), "Community post comment body.", new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3761), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3761), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("8743e248-4a73-4669-84e8-c366a87e0370"), "Community post comment body.", new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3716), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3717), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                    { new Guid("cb93a714-504d-40d2-816f-fd5a1a17da3c"), "Community post comment body.", new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3759), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3759), "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                    { new Guid("f47d93bf-e256-44e1-a7f1-815d9b9f78df"), "Community post comment body.", new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3723), null, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3723), "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
                });

            migrationBuilder.InsertData(
                table: "CommunityPostImages",
                columns: new[] { "Id", "CommunityPostId", "CreatedDate", "FileExtension", "FileName", "FileSize", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d89ce26-d294-4dc5-9d9c-406039c0d949"), new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3633), "png", "community-post-image-6", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3634) },
                    { new Guid("3ed2a280-f246-4a40-9b89-43db28812980"), new Guid("d3132383-9763-427a-9079-fd57b46fbf56"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3631), "png", "community-post-image-5", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3631) },
                    { new Guid("6e1106bb-ec63-40c2-8061-961b06c30f81"), new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3621), "png", "community-post-image-1", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3622) },
                    { new Guid("8d07ba22-fd4f-4c17-a0c3-a100a1104b1d"), new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3629), "png", "community-post-image-4", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3629) },
                    { new Guid("9f6b798a-e979-49f0-a2b5-09631faf1eca"), new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3637), "png", "community-post-image-8", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3638) },
                    { new Guid("d4df3e7d-e0ff-4622-badb-1fc557cfbda3"), new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3636), "png", "community-post-image-7", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3636) },
                    { new Guid("e375c1d7-f815-4174-b269-18958b330e1d"), new Guid("27e480c1-d49a-4e67-996c-1410ad424758"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3625), "png", "community-post-image-2", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3625) },
                    { new Guid("fb9429c1-4564-410d-a450-3ea6f14639c7"), new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb"), new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3627), "png", "community-post-image-3", 10.0, new DateTime(2023, 4, 24, 6, 53, 19, 631, DateTimeKind.Utc).AddTicks(3627) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CoverImageIdId",
                table: "AspNetUsers",
                column: "CoverImageIdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileImageIdId",
                table: "AspNetUsers",
                column: "ProfileImageIdId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorGenres_AuthorId",
                table: "AuthorGenres",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorGenres_GenreId",
                table: "AuthorGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorImages_AuthorId",
                table: "AuthorImages",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorRecommendations_AuthorId",
                table: "AuthorRecommendations",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorRecommendations_RecipientUserId",
                table: "AuthorRecommendations",
                column: "RecipientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorRecommendations_RecommenderUserId",
                table: "AuthorRecommendations",
                column: "RecommenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviewDislikes_AuthorReviewId",
                table: "AuthorReviewDislikes",
                column: "AuthorReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviewDislikes_UserId",
                table: "AuthorReviewDislikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviewImages_AuthorReviewId",
                table: "AuthorReviewImages",
                column: "AuthorReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviewLikes_AuthorReviewId",
                table: "AuthorReviewLikes",
                column: "AuthorReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviewLikes_UserId",
                table: "AuthorReviewLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviews_AuthorId",
                table: "AuthorReviews",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReviews_UserId",
                table: "AuthorReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CreatorUserId",
                table: "Authors",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSubscriptions_AuthorId",
                table: "AuthorSubscriptions",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSubscriptions_UserId",
                table: "AuthorSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_BookId",
                table: "BookGenres",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookImages_BookId",
                table: "BookImages",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRecommendations_BookId",
                table: "BookRecommendations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRecommendations_RecipientUserId",
                table: "BookRecommendations",
                column: "RecipientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRecommendations_RecommenderUserId",
                table: "BookRecommendations",
                column: "RecommenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviewDislikes_BookReviewId",
                table: "BookReviewDislikes",
                column: "BookReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviewDislikes_UserId",
                table: "BookReviewDislikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviewImages_BookReviewId",
                table: "BookReviewImages",
                column: "BookReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviewLikes_BookReviewId",
                table: "BookReviewLikes",
                column: "BookReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviewLikes_UserId",
                table: "BookReviewLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviews_BookId",
                table: "BookReviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviews_UserId",
                table: "BookReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CreatorUserId",
                table: "Books",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookSubscriptions_BookId",
                table: "BookSubscriptions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookSubscriptions_UserId",
                table: "BookSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_CoverImageId",
                table: "Communities",
                column: "CoverImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_OwnerUserId",
                table: "Communities",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_ProfileImageId",
                table: "Communities",
                column: "ProfileImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityGenres_CommunityId",
                table: "CommunityGenres",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityGenres_GenreId",
                table: "CommunityGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMembers_CommunityId",
                table: "CommunityMembers",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMembers_UserId",
                table: "CommunityMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityModerators_CommunityId",
                table: "CommunityModerators",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityModerators_UserId",
                table: "CommunityModerators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPostComments_CommunityPostId",
                table: "CommunityPostComments",
                column: "CommunityPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPostComments_ParentCommentId",
                table: "CommunityPostComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPostComments_UserId",
                table: "CommunityPostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPostImages_CommunityPostId",
                table: "CommunityPostImages",
                column: "CommunityPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_CommunityId",
                table: "CommunityPosts",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPosts_UserId",
                table: "CommunityPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_UserId",
                table: "Genres",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteBooks_BookId",
                table: "UserFavoriteBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteBooks_UserId",
                table: "UserFavoriteBooks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialMedias_SocialMediaPlatformId",
                table: "UserSocialMedias",
                column: "SocialMediaPlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialMedias_UserId",
                table: "UserSocialMedias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWantToReadBooks_BookId",
                table: "UserWantToReadBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWantToReadBooks_UserId",
                table: "UserWantToReadBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorGenres");

            migrationBuilder.DropTable(
                name: "AuthorImages");

            migrationBuilder.DropTable(
                name: "AuthorRecommendations");

            migrationBuilder.DropTable(
                name: "AuthorReviewDislikes");

            migrationBuilder.DropTable(
                name: "AuthorReviewImages");

            migrationBuilder.DropTable(
                name: "AuthorReviewLikes");

            migrationBuilder.DropTable(
                name: "AuthorSubscriptions");

            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "BookImages");

            migrationBuilder.DropTable(
                name: "BookRecommendations");

            migrationBuilder.DropTable(
                name: "BookReviewDislikes");

            migrationBuilder.DropTable(
                name: "BookReviewImages");

            migrationBuilder.DropTable(
                name: "BookReviewLikes");

            migrationBuilder.DropTable(
                name: "BookSubscriptions");

            migrationBuilder.DropTable(
                name: "CommunityGenres");

            migrationBuilder.DropTable(
                name: "CommunityMembers");

            migrationBuilder.DropTable(
                name: "CommunityModerators");

            migrationBuilder.DropTable(
                name: "CommunityPostComments");

            migrationBuilder.DropTable(
                name: "CommunityPostImages");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "UserFavoriteBooks");

            migrationBuilder.DropTable(
                name: "UserSocialMedias");

            migrationBuilder.DropTable(
                name: "UserWantToReadBooks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AuthorReviews");

            migrationBuilder.DropTable(
                name: "BookReviews");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "CommunityPosts");

            migrationBuilder.DropTable(
                name: "UserSocialMediaPlatforms");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CommunityImages");

            migrationBuilder.DropTable(
                name: "UserImages");
        }
    }
}
