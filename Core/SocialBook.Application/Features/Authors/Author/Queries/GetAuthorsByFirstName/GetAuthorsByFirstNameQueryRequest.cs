using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryRequest : IRequest<List<GetAuthorsByFirstNameQueryResponse>>
    {
        /// <summary>
        /// The first name
        /// </summary>
        /// <example>Charles</example>
        public string FirstName { get; set; }
    }
}
