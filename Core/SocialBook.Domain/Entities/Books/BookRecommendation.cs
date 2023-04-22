using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Books
{
    public class BookRecommendation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the recommended book identifier
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the recommended book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the recommender user identifier
        /// </summary>
        public string RecommenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the recommender user
        /// </summary>
        public AppUser RecommenderUser { get; set; }

        /// <summary>
        /// Gets or sets the recommendation recipient user identifier
        /// </summary>
        public string RecipientUserId { get; set; }

        /// <summary>
        /// Gets or sets the recommendation recipient user
        /// </summary>
        public AppUser RecipientUser { get; set; }
    }
}
