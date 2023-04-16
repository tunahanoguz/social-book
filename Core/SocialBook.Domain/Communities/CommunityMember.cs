using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityMember : BaseEntity
    {
        /// <summary>
        /// Gets or sets the community the user is a member of
        /// </summary>
        public Community Community { get; set; }

        /// <summary>
        /// Gets or sets the member user
        /// </summary>
        public AppUser User { get; set; }
    }
}
