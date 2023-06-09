﻿using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Communities
{
    public class CommunityPost : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the community that the post was published
        /// </summary>
        public Guid CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the community that the post was published
        /// </summary>
        public Community Community { get; set; }

        /// <summary>
        /// Gets or sets the post owner user identifier
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the post owner user
        /// </summary>
        public AppUser User { get; set; }

        /// <summary>
        /// Gets or sets all community post images
        /// </summary>
        public ICollection<CommunityPostImage> Images { get; set; }
    }
}
