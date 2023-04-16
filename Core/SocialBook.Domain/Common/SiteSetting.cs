namespace SocialBook.Domain.Common
{
    public class SiteSetting : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the meta description for SEO
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta keywords for SEO
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets page title seperator
        /// </summary>
        public string PageTitleSeperator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether authorized users are allowed to create a new book
        /// </summary>
        public bool IsAllowedNewBook { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether authorized users are allowed to upload an image for a book
        /// </summary>
        public bool IsAllowedBookImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to publish a new book review
        /// </summary>
        public bool IsAllowedBookReview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to like a book review
        /// </summary>
        public bool IsAllowedBookReviewLike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to dislike a book review
        /// </summary>
        public bool IsAllowedBookReviewDislike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to recommend a book to another users
        /// </summary>
        public bool IsAllowedBookRecommendation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to subscribe to a book
        /// </summary>
        public bool IsAllowedBookSubscription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether authorized users are allowed to create a new author
        /// </summary>
        public bool IsAllowedNewAuthor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether authorized users are allowed to upload an image for an author
        /// </summary>
        public bool IsAllowedAuthorImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to publish a new author review
        /// </summary>
        public bool IsAllowedAuthorReview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to like an author review
        /// </summary>
        public bool IsAllowedAuthorReviewLike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to dislike an author review
        /// </summary>
        public bool IsAllowedAuthorReviewDislike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to recommend an author to another users
        /// </summary>
        public bool IsAllowedAuthorRecommendation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to subscribe to an author
        /// </summary>
        public bool IsAllowedAuthorSubscription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether authorized users are allowed to create a new genre
        /// </summary>
        public bool IsAllowedNewGenre { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to create a new community
        /// </summary>
        public bool IsAllowedNewCommunity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to upload a new profile image for a community
        /// </summary>
        public bool IsAllowedCommunityProfileImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to upload a new cover image for a community
        /// </summary>
        public bool IsAllowedCommunityCoverImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to be a member of a community
        /// </summary>
        public bool IsAllowedCommunityMembership { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether community owner are allowed to assing a moderator for a community
        /// </summary>
        public bool IsAllowedNewCommunityModerator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to publish a new post for a community
        /// </summary>
        public bool IsAllowedNewCommunityPost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to make a comment for a community post
        /// </summary>
        public bool IsAllowedNewCommunityPostComment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether new user registration is active
        /// </summary>
        public bool IsAllowedNewUserRegistration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to upload a new profile image
        /// </summary>
        public bool IsAllowedUserProfileImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to upload a new cover image
        /// </summary>
        public bool IsAllowedUserCoverImageUpload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to favorite a book
        /// </summary>
        public bool IsAllowedNewUserFavoriteBook { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to add a book to want-to-read list
        /// </summary>
        public bool IsAllowedNewUserWantToReadBook { get; set; }
    }
}
