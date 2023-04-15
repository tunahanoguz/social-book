using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityMember : BaseEntity
    {
        public Community Community { get; set; }
        public AppUser User { get; set; }
    }
}
