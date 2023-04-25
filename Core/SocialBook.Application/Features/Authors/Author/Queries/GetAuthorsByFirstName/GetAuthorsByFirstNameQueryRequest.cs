using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByFirstNameQueryRequest : IRequest<GetAuthorsByFirstNameQueryResponse>
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }
    }
}
