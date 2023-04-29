using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByLastNameQueryRequest : PaginationFilter, IRequest<List<GetAuthorsByLastNameQueryResponse>>
    {
        /// <summary>
        /// The last name
        /// </summary>
        /// <example>Dickens</example>
        public string LastName { get; set; }
    }
}
