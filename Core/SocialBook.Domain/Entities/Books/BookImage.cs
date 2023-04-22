using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Books
{
    public class BookImage : BaseEntity
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
        /// Gets or sets the associated book identifier
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the associated book
        /// </summary>
        public Book Book { get; set; }
    }
}
