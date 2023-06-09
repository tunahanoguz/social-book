﻿using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Books
{
    public class BookGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book identifier
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the book genre identifier
        /// </summary>
        public Guid GenreId { get; set; }

        /// <summary>
        /// Gets or sets the book genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
