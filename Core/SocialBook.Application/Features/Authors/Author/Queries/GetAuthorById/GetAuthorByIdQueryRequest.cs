using MediatR;

namespace SocialBook.Application.Features
{
    public class GetAuthorByIdQueryRequest : IRequest<GetAuthorByIdQueryResponse>
    {
        public string AuthorId { get; set; }
    }
}
