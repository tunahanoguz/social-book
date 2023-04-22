using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Authors
{
    public class AuthorRecommendation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the recommended author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the recommended author
        /// </summary>
        public Author Author { get; set; }

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
