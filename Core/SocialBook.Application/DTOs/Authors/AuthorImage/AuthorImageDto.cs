namespace SocialBook.Application.DTOs.Authors.AuthorImage
{
    public class AuthorImageDto
    {
        /// <summary>
        /// The author image identifier
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
        /// The author identifier
        /// </summary>
        public Guid AuthorId { get; set; }
    }
}
