using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByLastNameQueryRequest : PaginationFilter, IRequest<PaginatedListDto<AuthorDto>>
    {
        /// <summary>
        /// The last name
        /// </summary>
        /// <example>Dickens</example>
        public string LastName { get; set; }
    }
}
