using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Authors
{
    public class AuthorRecommendation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the recommended author
        /// </summary>
        public Author Author { get; set; }

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
