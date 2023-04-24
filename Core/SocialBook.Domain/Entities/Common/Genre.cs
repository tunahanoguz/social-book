using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Common
{
    public class Genre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets meta title for SEO
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets meta description for SEO
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets meta keywords for SEO
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the creator user identifier
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the creator user
        /// </summary>
        public AppUser User { get; set; }
    }
}
