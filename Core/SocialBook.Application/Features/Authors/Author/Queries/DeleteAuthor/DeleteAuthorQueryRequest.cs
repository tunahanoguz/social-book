using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class DeleteAuthorQueryRequest : IRequest<DeleteAuthorQueryResponse>
    {
        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        public string Id { get; set; }
    }
}
