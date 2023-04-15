using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityModerator : BaseEntity
    {
        public Community Community { get; set; }
        public AppUser User { get; set; }
    }
}
