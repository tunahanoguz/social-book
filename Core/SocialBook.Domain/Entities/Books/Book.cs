using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Books
{
    public class Book : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the international standard book number
        /// </summary>
        public string Isbn { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the published year
        /// </summary>
        public int PublishedYear { get; set; }

        /// <summary>
        /// Gets or sets the page count
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the language of book
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the meta title for SEO
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets the meta description for SEO
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta keywords for SEO
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets the slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to publish review about the book
        /// </summary>
        public bool IsAllowedReview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to recommend the book to another users
        /// </summary>
        public bool IsAllowedRecommendation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to subscribe the book to be informed about new updates
        /// </summary>
        public bool IsAllowedSubscription { get; set; }

        /// <summary>
        /// Gets or sets the creator user
        /// </summary>
        public AppUser CreatorUser { get; set; }
    }
}
