using MediatR;

namespace SocialBook.Application.Features
{
    public class GetAuthorByIdQueryRequest : IRequest<GetAuthorByIdQueryResponse>
    {
        /// <summary>
        /// Gets or sets the author identifier
        /// </summary>
        public string AuthorId { get; set; }
    }
}
