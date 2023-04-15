using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Users
{
    public class UserSocialMedia : BaseEntity
    {
        /// <summary>
        /// Gets or sets the social media platform username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the associated social media platform
        /// </summary>
        public UserSocialMediaPlatform SocialMediaPlatform { get; set; }

        /// <summary>
        /// Gets or sets the owner user of the social media account
        /// </summary>
        public AppUser User { get; set; }
    }
}
