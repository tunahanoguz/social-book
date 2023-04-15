using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Authors
{
    public class AuthorSubscription : BaseEntity
    {
        /// <summary>
        /// Gets or sets the subscribed author
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the user who subscribed to the author
        /// </summary>
        public AppUser User { get; set; }
    }
}
