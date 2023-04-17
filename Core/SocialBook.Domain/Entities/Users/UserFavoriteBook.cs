using SocialBook.Domain.Entities.Books;
using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Users
{
    public class UserFavoriteBook : BaseEntity
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
