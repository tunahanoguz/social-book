using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Books
{
    public class BookReviewImage : BaseEntity
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
        /// Gets or sets the associated book review
        /// </summary>
        public BookReview BookReview { get; set; }
    }
}
