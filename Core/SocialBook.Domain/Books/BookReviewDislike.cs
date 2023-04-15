﻿using SocialBook.Domain.Common;
using SocialBook.Domain.Identity;

namespace SocialBook.Domain.Books
{
    public class BookReviewDislike : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book review
        /// </summary>
        public BookReview BookReview { get; set; }

        /// <summary>
        /// Gets or sets the user who liked the book review
        /// </summary>
        public AppUser User { get; set; }
    }
}
