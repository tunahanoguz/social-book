using SocialBook.Domain.Common;

namespace SocialBook.Domain.Authors
{
    public class AuthorGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the author genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
