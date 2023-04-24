using SocialBook.Domain.Entities.Common;
using SocialBook.Domain.Entities.Identity;

namespace SocialBook.Domain.Entities.Communities
{
    public class CommunityPostComment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the comment body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the associated community post identifier
        /// </summary>
        public Guid CommunityPostId { get; set; }

        /// <summary>
        /// Gets or sets the associated community post
        /// </summary>
        public CommunityPost CommunityPost { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the parent comment if the comment has been made for another comment
        /// </summary>
        public Guid? ParentCommentId { get; set; }

        /// <summary>
        /// Gets or sets the parent comment if the comment has been made for another comment
        /// </summary>
        public CommunityPostComment ParentComment { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who commented
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user who commented
        /// </summary>
        public AppUser User { get; set; }
    }
}
