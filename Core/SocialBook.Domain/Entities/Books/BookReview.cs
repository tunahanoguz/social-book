using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Books
{
    public class BookReview : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book rating (between 1-5 points)
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the comment about associated book
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the reviewed book identifier
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the reviewed book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the book reviwer user identifier
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the book reviwer user
        /// </summary>
        public AppUser User { get; set; }

        /// <summary>
        /// Gets or sets book review images
        /// </summary>
        public ICollection<BookReviewImage> Images { get; set; }
    }
}
