using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Communities
{
    public class Community : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of the community
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description about the community
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to see community post without being a member
        /// </summary>
        public bool IsPrivate { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to be a member of the community
        /// </summary>
        public bool IsAllowedMembership { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether owner user is allowed to assing a new moderator to the community
        /// </summary>
        public bool IsAllowedNewModerator { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to create a new post for the community
        /// </summary>
        public bool IsAllowedNewPost { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to make a new comment to a community post
        /// </summary>
        public bool IsAllowedNewPostComment { get; set; } = true;

        /// <summary>
        /// Gets or sets the profile image identifier
        /// </summary>
        public Guid ProfileImageId { get; set; }

        /// <summary>
        /// Gets or sets the profile image
        /// </summary>
        public CommunityImage ProfileImage { get; set; }

        /// <summary>
        /// Gets or sets the cover image identifier
        /// </summary>
        public Guid CoverImageId { get; set; }

        /// <summary>
        /// Gets or sets the cover image id
        /// </summary>
        public CommunityImage CoverImage { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the owner user of the community
        /// </summary>
        public string OwnerUserId { get; set; }

        /// <summary>
        /// Gets or sets the owner user of the community
        /// </summary>
        public AppUser OwnerUser { get; set; }
    }
}
