using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Books
{
    public class BookReviewLike : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book review
        /// </summary>
        public BookReview BookReview { get; set; }

        /// <summary>
        /// Gets or sets the user who liked the book review
        /// </summary>
        public AppUser User { get; set; }
    }
}
