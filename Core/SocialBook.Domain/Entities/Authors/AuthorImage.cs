﻿using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Authors
{
    public class AuthorImage : BaseEntity
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
        /// Gets or sets the author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the associated author
        /// </summary>
        public Author Author { get; set; }
    }
}
