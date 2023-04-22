using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Books
{
    public class BookSubscription : BaseEntity
    {
        /// <summary>
        /// Gets or sets the subscribed book identifier
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the subscribed book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who subscribed to the book
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user who subscribed to the book
        /// </summary>
        public AppUser User { get; set; }
    }
}
