using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Books
{
    public class BookSubscription : BaseEntity
    {
        /// <summary>
        /// Gets or sets the subscribed book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the user who subscribed to the book
        /// </summary>
        public AppUser User { get; set; }
    }
}
