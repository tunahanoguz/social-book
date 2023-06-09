﻿using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Communities
{
    public class CommunityGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the community identifier
        /// </summary>
        public Guid CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the community
        /// </summary>
        public Community Community { get; set; }

        /// <summary>
        /// Gets or sets the community genre identifier
        /// </summary>
        public Guid GenreId { get; set; }

        /// <summary>
        /// Gets or sets the community genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
