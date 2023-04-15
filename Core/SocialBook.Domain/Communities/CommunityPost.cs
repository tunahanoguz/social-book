using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityPost : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Community Community { get; set; }
        public AppUser User { get; set; }
    }
}
