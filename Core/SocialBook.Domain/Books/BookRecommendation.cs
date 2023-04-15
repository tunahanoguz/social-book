using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Books
{
    public class BookRecommendation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the recommended book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the recommender user
        /// </summary>
        public AppUser RecommenderUser { get; set; }

        /// <summary>
        /// Gets or sets the recommendation recipient user
        /// </summary>
        public AppUser RecipientUser { get; set; }
    }
}
