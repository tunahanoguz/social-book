﻿using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Authors
{
    public class AuthorReview : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author rating (between 1-5 points)
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the comment about associated author
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the reviewed author
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the author reviwer user
        /// </summary>
        public AppUser User { get; set; }
    }
}