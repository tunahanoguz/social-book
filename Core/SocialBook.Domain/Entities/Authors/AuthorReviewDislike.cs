using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Authors
{
    public class AuthorReviewDislike : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author review identifier
        /// </summary>
        public Guid AuthorReviewId { get; set; }

        /// <summary>
        /// Gets or sets the author review
        /// </summary>
        public AuthorReview AuthorReview { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who disliked the author review
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user who disliked the author review
        /// </summary>
        public AppUser User { get; set; }
    }
}
