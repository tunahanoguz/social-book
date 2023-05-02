namespace SocialBook.Application.DTOs.Authors.AuthorRecommendation
{
    public class AuthorRecommendationDto
    {
        /// <summary>
        /// Gets or sets the recommended author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the recommender user identifier
        /// </summary>
        public string RecommenderUserId { get; set; }

        /// <summary>
        /// Gets or sets the recommendation recipient user identifier
        /// </summary>
        public string RecipientUserId { get; set; }
    }
}
