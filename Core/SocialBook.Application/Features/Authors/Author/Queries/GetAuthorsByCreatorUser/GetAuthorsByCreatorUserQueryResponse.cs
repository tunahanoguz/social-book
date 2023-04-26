namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCreatorUserQueryResponse
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the description about the author
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the country of birth of the author
        /// </summary>
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the author
        /// </summary>
        public DateTime DateOfBirth { get; set; }

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
        /// Gets or sets a value indicating whether users are allowed to publish review about the author
        /// </summary>
        public bool IsAllowedReview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to recommend the author to another users
        /// </summary>
        public bool IsAllowedRecommendation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to subscribe the author to be informed about new updates
        /// </summary>
        public bool IsAllowedSubscription { get; set; }

        /// <summary>
        /// Gets or sets the creator user identifier
        /// </summary>
        public string CreatorUserId { get; set; }
    }
}
