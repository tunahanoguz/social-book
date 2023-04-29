using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryRequest : PaginationFilter, IRequest<List<GetAuthorsByFirstNameQueryResponse>>
    {
        /// <summary>
        /// The first name
        /// </summary>
        /// <example>Charles</example>
        [FromRoute]
        public string FirstName { get; set; }
    }
}
