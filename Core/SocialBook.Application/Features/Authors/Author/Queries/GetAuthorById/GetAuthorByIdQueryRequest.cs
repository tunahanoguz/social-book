using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorByIdQueryRequest : IRequest<GetAuthorByIdQueryResponse>
    {
        /// <summary>
        /// Gets or sets the author identifier
        /// </summary>
        public string AuthorId { get; set; }
    }
}
