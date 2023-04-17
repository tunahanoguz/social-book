using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Communities
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
