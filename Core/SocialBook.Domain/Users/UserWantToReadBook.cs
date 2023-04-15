using SocialBook.Domain.Books;
using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Users
{
    public class UserWantToReadBook : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user
        /// </summary>
        public AppUser User { get; set; }

        /// <summary>
        /// Gets or sets the book
        /// </summary>
        public Book Book { get; set; }
    }
}
