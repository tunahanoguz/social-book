using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByFirstNameQueryResponse
    {
        public List<Author> Authors { get; set; }
    }
}
