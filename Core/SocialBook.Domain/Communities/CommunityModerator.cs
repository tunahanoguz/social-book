using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityModerator : BaseEntity
    {
        /// <summary>
        /// Gets or sets the community the user is a moderator of
        /// </summary>
        public Community Community { get; set; }

        /// <summary>
        /// Gets or sets the moderator user
        /// </summary>
        public AppUser User { get; set; }
    }
}
