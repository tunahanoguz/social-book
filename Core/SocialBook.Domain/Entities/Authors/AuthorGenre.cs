using SocialBook.Domain.Entities.Common;

namespace SocialBook.Domain.Entities.Authors
{
    public class AuthorGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the genre identifier
        /// </summary>
        public Guid GenreId { get; set; }

        /// <summary>
        /// Gets or sets the author genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
