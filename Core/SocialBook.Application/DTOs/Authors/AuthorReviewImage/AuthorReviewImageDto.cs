namespace SocialBook.Application.DTOs.Authors.AuthorReviewImage
{
    public class AuthorReviewImageDto
    {
        /// <summary>
        /// The author review image identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The image file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The image file extension
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// The image file size
        /// </summary>
        public double FileSize { get; set; }

        /// <summary>
        /// The associated author review identifier
        /// </summary>
        public Guid AuthorReviewId { get; set; }
    }
}
