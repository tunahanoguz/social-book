﻿using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Communities
{
    public class CommunityPostComment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the comment body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the associated community post
        /// </summary>
        public CommunityPost CommunityPost { get; set; }

        /// <summary>
        /// Gets or sets the parent comment if the comment has been made for another comment
        /// </summary>
        public CommunityPostComment ParentComment { get; set; }

        /// <summary>
        /// Gets or sets the user who commented
        /// </summary>
        public AppUser User { get; set; }
    }
}
