using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Communities
{
    public class CommunityPostImage : BaseEntity
    {
        /// <summary>
        /// Gets or sets the image file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the image file extension
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the image file size
        /// </summary>
        public double FileSize { get; set; }

        /// <summary>
        /// Gets or sets the associated community post identifier
        /// </summary>
        public Guid CommunityPostId { get; set; }

        /// <summary>
        /// Gets or sets the associated community post
        /// </summary>
        public CommunityPost CommunityPost { get; set; }
    }
}
