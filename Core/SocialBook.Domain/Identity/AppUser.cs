using Microsoft.AspNetCore.Identity;
using SocialBook.Domain.Users;

namespace SocialBook.Domain.Identity
{
    public class AppUser: IdentityUser<string>
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the profile image identifier
        /// </summary>
        public UserImage ProfileImageId { get; set; }

        /// <summary>
        /// Gets or sets the cover image identifier
        /// </summary>
        public UserImage CoverImageId { get; set; }
    }
}
