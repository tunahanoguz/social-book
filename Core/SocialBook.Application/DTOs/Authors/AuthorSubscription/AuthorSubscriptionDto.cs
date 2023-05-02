namespace SocialBook.Application.DTOs.Authors.AuthorSubscription
{
    public class AuthorSubscriptionDto
    {
        /// <summary>
        /// The subscribed author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// The identifier of the user who subscribed to the author
        /// </summary>
        public string UserId { get; set; }
    }
}
