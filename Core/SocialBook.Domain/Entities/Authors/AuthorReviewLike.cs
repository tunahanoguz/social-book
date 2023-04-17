using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Authors
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
