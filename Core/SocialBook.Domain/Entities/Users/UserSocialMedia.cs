﻿using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Users
{
    public class UserSocialMedia : BaseEntity
    {
        /// <summary>
        /// Gets or sets the social media platform username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the associated social media platform identifier
        /// </summary>
        public Guid SocialMediaPlatformId { get; set; }

        /// <summary>
        /// Gets or sets the associated social media platform
        /// </summary>
        public UserSocialMediaPlatform SocialMediaPlatform { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the owner user of the social media account
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the owner user of the social media account
        /// </summary>
        public AppUser User { get; set; }
    }
}
