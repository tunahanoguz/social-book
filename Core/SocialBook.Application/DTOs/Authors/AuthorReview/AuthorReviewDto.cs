namespace SocialBook.Application.DTOs.Authors.AuthorReview
{
    public class AuthorReviewDto
    {
        /// <summary>
        /// The author rating (between 1-5 points)
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// The comment about associated author
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// The author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// The user identifier
        /// </summary>
        public string UserId { get; set; }
    }
}
