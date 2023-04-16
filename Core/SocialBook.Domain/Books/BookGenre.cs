using SocialBook.Domain.Common;

namespace SocialBook.Domain.Books
{
    public class BookGenre : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the book genre
        /// </summary>
        public Genre Genre { get; set; }
    }
}
