namespace SocialBook.Application.DTOs.Authors.AuthorReviewLike
{
    public class AuthorReviewLikeDto
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
