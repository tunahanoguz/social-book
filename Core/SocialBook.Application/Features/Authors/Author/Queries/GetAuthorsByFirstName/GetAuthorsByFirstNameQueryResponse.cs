using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByFirstNameQueryResponse
    {
        /// <summary>
        /// Gets or sets the list of the authors
        /// </summary>
        public List<Author> Authors { get; set; }
    }
}
