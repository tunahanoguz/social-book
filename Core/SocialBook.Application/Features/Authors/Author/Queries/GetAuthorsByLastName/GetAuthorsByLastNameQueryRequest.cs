using MediatR;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByLastNameQueryRequest : IRequest<List<GetAuthorsByLastNameQueryResponse>>
    {
        /// <summary>
        /// The last name
        /// </summary>
        /// <example>Dickens</example>
        public string LastName { get; set; }
    }
}
