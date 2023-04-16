using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Books
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
        /// Gets or sets the reviewed book
        /// </summary>
        public Book Book { get; set; }

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
