using SocialBook.Domain.Common;

namespace SocialBook.Domain.Communities
{
    public class CommunityGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the community
        /// </summary>
        public Community Community { get; set; }

        /// <summary>
        /// Gets or sets the community genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
