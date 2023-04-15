using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Authors
{
    public class AuthorReviewLike : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author review
        /// </summary>
        public AuthorReview AuthorReview { get; set; }

        /// <summary>
        /// Gets or sets the user who liked the author review
        /// </summary>
        public AppUser User { get; set; }
    }
}
