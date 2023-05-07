using MediatR;
using SocialBook.Application.DTOs.Authors.Author;

namespace SocialBook.Application.Features.Commands
{
    public class UpdateAuthorCommandRequest : IRequest<AuthorDto>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        public string Id { get; set; }

        /// <summary>
        /// The first name
        /// </summary>
        /// <example>Updated Ernest</example>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name
        /// </summary>
        /// <example>Updated Hemingway</example>
        public string LastName { get; set; }

        /// <summary>
        /// The description about the author
        /// </summary>
        /// <example>The description about updated Ernest Hemingway.</example>
        public string Description { get; set; }

        /// <summary>
        /// The country of birth of the author
        /// </summary>
        /// <example>The United States</example>
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// The date of birth of the author
        /// </summary>
        /// <example>1899-07-21T06:06:38.723Z</example>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The meta title for SEO
        /// </summary>
        /// <example>Ernest Hemingway</example>
        public string MetaTitle { get; set; }

        /// <summary>
        /// The meta description for SEO
        /// </summary>
        /// <example>The meta description about updated Ernest Hemingway.</example>
        public string MetaDescription { get; set; }

        /// <summary>
        /// The meta keywords for SEO
        /// </summary>
        /// <example>ernest hemingway author, ernest hemingway books</example>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// The slug
        /// </summary>
        /// <example>ernest-hemingway</example>
        public string Slug { get; set; }

        /// <summary>
        /// A value indicating whether users are allowed to publish review about the author
        /// </summary>
        /// <example>true</example>
        public bool IsAllowedReview { get; set; }

        /// <summary>
        /// A value indicating whether users are allowed to recommend the author to another users
        /// </summary>
        /// <example>true</example>
        public bool IsAllowedRecommendation { get; set; }

        /// <summary>
        /// A value indicating whether users are allowed to subscribe the author to be informed about new updates
        /// </summary>
        /// <example>true</example>
        public bool IsAllowedSubscription { get; set; }

        /// <summary>
        /// The creator user identifier
        /// </summary>
        /// <example>92088e43-474e-4bd6-9dbe-cfc5293e885f</example>
        public string CreatorUserId { get; set; }
    }
}
