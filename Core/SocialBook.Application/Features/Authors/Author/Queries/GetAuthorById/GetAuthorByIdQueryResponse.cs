using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features
{
    public class GetAuthorByIdQueryResponse
    {
        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public Author Author { get; set; }
    }
}
