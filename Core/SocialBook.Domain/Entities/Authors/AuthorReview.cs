using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Authors
{
    public class AuthorReview : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author rating (between 1-5 points)
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the comment about associated author
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the reviewed author
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the author reviwer user
        /// </summary>
        public AppUser User { get; set; }

        /// <summary>
        /// Gets or sets all author review images
        /// </summary>
        public ICollection<AuthorReviewImage> Images { get; set; }
    }
}
