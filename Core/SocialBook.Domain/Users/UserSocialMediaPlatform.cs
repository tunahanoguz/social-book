using SocialBook.Domain.Common;

namespace SocialBook.Domain.Users
{
    public class UserSocialMediaPlatform : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of the social media platform (Facebook, Twitter etc.)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the uri prefix to use on frontend
        /// </summary>
        public string UrlPrefix { get; set; }

        /// <summary>
        /// Gets or sets the uri postfix to use on frontend
        /// </summary>
        public string UrlPostfix { get; set; }
    }
}
