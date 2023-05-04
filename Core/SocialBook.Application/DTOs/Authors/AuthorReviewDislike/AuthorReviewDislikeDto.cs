namespace SocialBook.Application.DTOs.Authors.AuthorReviewDislike
{
    public class AuthorReviewDislikeDto
    {
        /// <summary>
        /// Gets or sets the author review identifier
        /// </summary>
        public Guid AuthorReviewId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who liked the author review
        /// </summary>
        public string UserId { get; set; }
    }
}
